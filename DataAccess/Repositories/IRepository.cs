using Domain;
using System;
using System.Collections.Generic;

namespace DataAccess.Repositories
{
    public interface IRepository<T> where T : class, IEntity
    {
        void Add(T item);
        void Delete(int id);
        void Update(T item);
        T Get(int id);
        List<T> Get();
        List<T> Get(Predicate<T> filter);
    }
}
