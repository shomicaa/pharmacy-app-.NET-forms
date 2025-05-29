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
        List<IEntity> GetAll(IEntity entity);
        List<IEntity> GetSpecific(IEntity entity);
        void Delete(IEntity entity);
    }
}
