﻿using Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Repositories
{
    public interface IUserRepository
    {
        User GetUser(Guid Id);
        IEnumerable<User> GetUsers();
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

        public IEnumerable<User> GetUsers()
        {
            return _context.Users.ToList();
        }
    }
}
