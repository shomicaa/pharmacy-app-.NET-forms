using Microsoft.Data.SqlClient;
using Domain;

namespace DatabaseBroker
{
    public class Broker
    {
        private SqlConnection connection;
        private SqlTransaction transaction;

        public Broker()
        {
            connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PharmacyApp;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
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
            string query = $"insert into {entity.TableName} output inserted.id values ({entity.InsertValues})";
            SqlCommand command = new SqlCommand(query, connection, transaction);
            object insertedId = command.ExecuteScalar();
            if(!(insertedId is int))
            {
                throw new Exception("Database error!");
            }
            return (int)insertedId;
        }
        public void Save(IEntity entity)
        {
            string query = $"insert into {entity.TableName} values ({entity.InsertValues})";
            SqlCommand command = new SqlCommand(query, connection, transaction);
            if (command.ExecuteNonQuery() != 1)
            {
                throw new Exception("Database error!");
            }
        }

        public void Update(IEntity entity)
        {
            string query = $"update {entity.TableName} set {entity.UpdateValues} where {entity.WhereCondition}";
            SqlCommand command = new SqlCommand(query, connection, transaction);
            if (command.ExecuteNonQuery() != 1)
            {
                throw new Exception("Database error!");
            }
        }

        public void Delete(IEntity entity)
        {
            string query = $"delete from {entity.TableName} where {entity.WhereCondition}";
            SqlCommand command = new SqlCommand(query, connection, transaction);
            if (command.ExecuteNonQuery() != 1)
            {
                throw new Exception("Database error!");
            }
        }

        public List<IEntity> GetAll(IEntity entity)
        {
            List<IEntity> result = new List<IEntity>();
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"select {entity.SelectValues} from {entity.TableName} ";
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
    }
}
