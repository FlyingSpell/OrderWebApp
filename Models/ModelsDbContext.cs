using Microsoft.EntityFrameworkCore;

namespace OrderWebApp.Models
{
    public class ModelsDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderHelperInfo> OrderHelperInfo { get; set; }
        public ModelsDbContext(DbContextOptions<ModelsDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
