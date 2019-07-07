using Microsoft.EntityFrameworkCore;
using WebAPI.DAL.Entities;

namespace WebAPI.DAL.Context
{
    public class WebContext : DbContext
    {

        public WebContext(DbContextOptions<WebContext> opts):base (opts)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderProduct>().HasKey(op => new { op.OrderId, op.ProductId });
            modelBuilder.Entity<CustomerOrder>().HasKey(co => new {co.CustomerId, co.OrderId});
            modelBuilder.Entity<CustomerAddress>().HasKey(ca => new { ca.CustomerId, ca.AddressId });
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<CustomerAddress> CustomerAddresseses { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProductses { get; set; }
        public DbSet<CustomerOrder> CustomerOrderses { get; set; }
    }
}
