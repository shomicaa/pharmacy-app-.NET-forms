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
            connection = new SqlConnection(@"MAKE A DATABASE");
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
            throw new NotImplementedException();
        }
        public void Save(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<IEntity> GetAll(IEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
