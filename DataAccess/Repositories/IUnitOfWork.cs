using Domain;

namespace DataAccess.Repositories
{
    public interface IUnitOfWork
    {
        IRepository<T> GetRepository<T>() where T : class, IEntity;
        void SaveContext();
    }
}
