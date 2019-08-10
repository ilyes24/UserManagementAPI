using Microsoft.EntityFrameworkCore;
using UserManagement.Entities;

namespace UserManagement.Helpers
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<UserEntity> Users { get; set; }
    }
}