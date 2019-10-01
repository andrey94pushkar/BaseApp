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

        public BaseAppDbContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=1-ПК\SQLEXPRESS;Database=BaseAppDb;Trusted_Connection=True;");
        }
    }
    
}
