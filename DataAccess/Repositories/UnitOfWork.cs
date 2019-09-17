using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DataAccess.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private DbContext _context;
        private Dictionary<Type, object> _repositories;
        public UnitOfWork()
        {
            _context = new BaseAppDbContext();
            _repositories = new Dictionary<Type, object>();
        }
        public void SaveContext()
        {
            _context.SaveChanges();
        }

        IRepository<T> IUnitOfWork.GetRepository<T>()
        {
            if (!_repositories.ContainsKey(typeof(T)))
            {
                _repositories.Add(typeof(T), new Repository<T>(_context));
            }
            return (IRepository<T>)_repositories[typeof(T)];
        }
    }
}