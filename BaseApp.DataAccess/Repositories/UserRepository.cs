using System;
using System.Collections.Generic;
using System.Linq;
using BaseApp.DataAccess.Models;

namespace BaseApp.DataAccess.Repositories
{
    public interface IUserRepository
    {
        User GetById(Guid Id);
        IEnumerable<User> GetUsers(string term);
        int Add(User user);
        int Update(User user);
    }

    public class UserRepository : IUserRepository
    {
        private BaseAppDbContext _context { get; set; }

        public UserRepository(BaseAppDbContext context)
        {
            _context = context;
        }

        public User GetById(Guid Id)
        {
            return _context.Users.FirstOrDefault(x => x.Id == Id);
        }

        public IEnumerable<User> GetUsers(string term)
        {
            return _context.Users.Where(x=>x.FullName.Contains(term)).ToList();
        }

        public int Add(User user)
        {
            _context.Users.Add(user);
            return _context.SaveChanges();
        }

        public int Update(User user)
        {
            _context.Users.Update(user);
            return _context.SaveChanges();
        }
    }
}
