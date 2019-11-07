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
            optionsBuilder.UseSqlServer(@"Data Source=WIN-VUHIBA9195M\SQLEXPRESS;Database=BaseAppDb;Trusted_Connection=True;");
        }
    }
    
}
