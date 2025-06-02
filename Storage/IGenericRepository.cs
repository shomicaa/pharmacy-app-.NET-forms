using System.Security.Principal;
using Domain;

namespace Storage
{
    public interface IGenericRepository
    {
        void OpenConnection();
        void CloseConnection();
        void BeginTransaction();
        void Commit();
        void Rollback();

        int Create(IEntity entity);
        void Save(IEntity entity);
        void Update(IEntity entity);
        IEntity Find(IEntity entity);
        List<IEntity> GetAll(IEntity entity);
        List<IEntity> GetSpecific(IEntity entity);
        List<IEntity> GetWithCondition(IJoinEntity entity);
        void Delete(IEntity entity);
    }
}
