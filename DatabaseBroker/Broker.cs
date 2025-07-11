using Microsoft.Data.SqlClient;
using Domain;
using System.Diagnostics;
//using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace DatabaseBroker
{
    public class Broker
    {
        private SqlConnection connection;
        private SqlTransaction transaction;

        public Broker()
        {
            string config = ConfigurationManager.ConnectionStrings["PharmacyApp"].ConnectionString;
            connection = new SqlConnection(config);
        }
        public void OpenConnection() => connection?.Open();

        public void CloseConnection() => connection?.Close();
        public void BeginTransaction()
        {
            transaction = connection.BeginTransaction();
        }

        public void Commit() => transaction.Commit();
        public void Rollback() => transaction.Rollback();

        public int Create(IEntity entity)
        {
            var insertParams = entity.GetInsertParameters();
            string columns = string.Join(", ", insertParams.Keys.Select(k => k.TrimStart('@')));
            string paramNames = string.Join(", ", insertParams.Keys);

            string query = $"INSERT INTO {entity.TableName} ({columns}) OUTPUT inserted.Id VALUES ({paramNames})";

            SqlCommand command = new SqlCommand(query, connection, transaction);
            foreach (var param in insertParams)
            {
                command.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
            }

            object insertedId = command.ExecuteScalar();
            if (!(insertedId is int))
            {
                throw new Exception("Database error!");
            }
            return (int)insertedId;
        }

        public void Save(IEntity entity)
        {
            var insertParams = entity.GetInsertParameters();
            string columns = string.Join(", ", insertParams.Keys.Select(k => k.TrimStart('@')));
            string paramNames = string.Join(", ", insertParams.Keys);

            string query = $"INSERT INTO {entity.TableName} ({columns}) VALUES ({paramNames})";

            SqlCommand command = new SqlCommand(query, connection, transaction);
            foreach (var param in insertParams)
            {
                command.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
            }

            if (command.ExecuteNonQuery() != 1)
            {
                throw new Exception("Database error!");
            }
        }

        public void Update(IEntity entity)
        {
            string query = $"UPDATE {entity.TableName} {entity.GetUpdateQuery()}";
            SqlCommand command = new SqlCommand(query, connection, transaction);

            var updateParams = entity.GetUpdateParameters();
            foreach (var param in updateParams)
            {
                command.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
            }

            if (command.ExecuteNonQuery() != 1)
            {
                throw new Exception("Database error!");
            }
        }

        public void Delete(IEntity entity)
        {
            string query = $"DELETE FROM {entity.TableName} WHERE {entity.GetDeleteCondition()}";
            SqlCommand command = new SqlCommand(query, connection, transaction);

            foreach (var param in entity.GetDeleteParameters())
            {
                command.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
            }

            if (command.ExecuteNonQuery() != 1)
            {
                throw new Exception("Database error!");
            }
        }

        public IEntity Find(IEntity entity)
        {
            try
            {
                using SqlCommand command = new SqlCommand
                {
                    Connection = connection,
                    Transaction = transaction,
                    CommandText = $"SELECT {entity.SelectValues} FROM {entity.TableName} WHERE {entity.GetFindCondition()}"
                };

                foreach (var pair in entity.GetFindParameters())
                {
                    command.Parameters.AddWithValue(pair.Key, pair.Value);
                }

                using SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return entity.ReadObjectRow(reader);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>>>>> Broker - Database error: "+ex.Message);
            }

            return null;
        }

        public List<IEntity> GetAll(IEntity entity)
        {
            try
            {
                List<IEntity> result = new List<IEntity>();
                SqlCommand command = new SqlCommand("", connection, transaction);
                command.CommandText = $"select {entity.SelectValues} from {entity.TableName}";
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        IEntity rowObject = entity.ReadObjectRow(reader);
                        result.Add(rowObject);
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>>>>> Broker - Database error: " + ex.Message);
                throw;
            }
        }

        public List<IEntity> GetSpecific(IEntity entity)
        {
            try
            {
                List<IEntity> results = new List<IEntity>();
                SqlCommand command = new SqlCommand("", connection, transaction);
                command.CommandText = $"SELECT {entity.SelectValues} FROM {entity.TableName} WHERE {entity.GetSearchCondition()}";

                foreach (var pair in entity.GetSearchParameters())
                {
                    command.Parameters.AddWithValue(pair.Key, pair.Value);
                }

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        IEntity rowObject = entity.ReadObjectRow(reader);
                        results.Add(rowObject);
                    }
                }
                return results;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>>>>> Broker - Database error: " + ex.Message);
                throw;
            }
        }

        public List<IEntity> GetWithCondition(IJoinEntity entity)
        {
            try
            {
                List<IEntity> results = new List<IEntity>();
                string query = $"SELECT {entity.SelectValues} FROM {entity.TableName} {entity.TableAlias} {entity.JoinClause} WHERE {entity.WhereClause}";

                using SqlCommand command = new SqlCommand(query, connection, transaction);

                foreach (var param in entity.JoinParameters)
                {
                    command.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                }

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        IEntity rowObject = entity.ReadObjectRow(reader);
                        results.Add(rowObject);
                    }
                }
                return results;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>>>>> Broker - Database error: " + ex.Message);
                throw;
            }
        }

    }
}
