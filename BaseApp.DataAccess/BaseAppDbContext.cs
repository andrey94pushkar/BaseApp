using Microsoft.EntityFrameworkCore;
using BaseApp.DataAccess.Models;

namespace BaseApp.DataAccess
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
