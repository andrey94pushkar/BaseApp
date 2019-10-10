using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class BaseAppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public BaseAppDbContext(DbContextOptions<BaseAppDbContext> options)
            :base(options)
        {
        }

        public BaseAppDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
<<<<<<< HEAD
            optionsBuilder.UseSqlServer(@"Data Source=1-ПК\SQLEXPRESS;Database=BaseAppDb;Trusted_Connection=True;");
=======
            optionsBuilder.UseSqlServer(@"Data Source=MServer;Database=BaseAppDb;Trusted_Connection=True;");
>>>>>>> f38fe2b8d50390c2b92244db4c6dd710351aacb5
        }
    }
    
}
