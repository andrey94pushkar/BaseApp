using System;
using System.Collections.Generic;
using System.Linq;
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace DataAccess.Repositories
{
    class Repository<T> : IRepository<T> where T : class, IEntity
    {
        private DbContext _context;
        internal Repository(DbContext context)
        {
            _context = context;
        }
        public void Add(T item)
        {
            _context.Set<T>().Add(item);
        }
        public void Delete(int id)
        {
            _context.Set<T>().Remove(Get(id));
        }
        public void Update(T item)
        {
            EntityEntry<T> dbEntityEntry = _context.Entry<T>(item);
            dbEntityEntry.State = EntityState.Modified;
        }
        public T Get(int id)
        {
            return _context.Set<T>().FirstOrDefault(arg => arg.Id == id);
        }
        public List<T> Get()
        {
            return _context.Set<T>().ToList();
        }
        public List<T> Get(Predicate<T> filter)
        {
            List<T> itemsToReturn = new List<T>();
            foreach (T item in _context.Set<T>().ToList())
            {
                bool isValid = filter(item);
                if (isValid)
                {
                    itemsToReturn.Add(item);
                }
            }
            return itemsToReturn;
        }
    }
}
