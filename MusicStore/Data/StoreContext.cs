using Microsoft.EntityFrameworkCore;
using MusicStore.Models;
namespace MusicStore.Data
{
    public class StoreContext:DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options):base(options){ }

        public DbSet<Product> Products => Set<Product>();
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<User> Users => Set<User>();
        public DbSet<Order> Order => Set<Order>();
    }
}
 