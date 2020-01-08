using System;
using System.Collections.Generic;
using System.Linq;
using BaseApp.DataAccess.Models;

namespace BaseApp.DataAccess.Repositories
{
    public interface IUserRepository
    {
        User GetUser(Guid Id);
        IEnumerable<User> GetUsers(string term);
    }

    public class UserRepository : IUserRepository
    {
        private BaseAppDbContext _context { get; set; }

        public UserRepository(BaseAppDbContext context)
        {
            _context = context;
        }

        public User GetUser(Guid Id)
        {
            return _context.Users.FirstOrDefault(x => x.Id == Id);
        }

        public IEnumerable<User> GetUsers(string term)
        {
            return _context.Users.Where(x=>
            x.FullName.Contains(term)).ToList();
        }
    }
}
