using Domain;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class BaseAppDbContext : DbContext
    {
        public BaseAppDbContext(DbContextOptions<BaseAppDbContext> options)
            :base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
