using Domain;
using Storage;

namespace SystemOperations
{
    public abstract class SystemOperationBase
    {
        protected IGenericRepository repository = new GenericRepository();

        public void ExecuteTemplate(IEntity entity)
        {
            try
            {
                repository.OpenConnection();
                repository.BeginTransaction();
                Execute(entity);
                repository.Commit();
            }
            catch (Exception)
            {
                repository.Rollback();
                throw;
            }
            finally
            {
                repository.CloseConnection();
            }
        }
        protected abstract void Execute(IEntity entity);
    }
}
