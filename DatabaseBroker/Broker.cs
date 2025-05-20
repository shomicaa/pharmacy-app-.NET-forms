using Microsoft.Data.SqlClient;

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
    }
}
