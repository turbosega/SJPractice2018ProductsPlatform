using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace StoreAPI.Models
{
    public class StoreDbContext : IdentityDbContext<AppUser>
    {
        public StoreDbContext(DbContextOptions opts) : base(opts)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
    }
}
