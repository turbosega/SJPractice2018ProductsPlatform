using Microsoft.EntityFrameworkCore;
using System.Linq;

using DAL.Entities;

namespace DAL
{
    public class StoreContext : DbContext
    {
        public DbSet<Assistant> Assistants { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet <Product> Products { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }

        // dotnet ef migrations add migrationname
        public StoreContext(DbContextOptions<StoreContext> options) :base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //default delete behaviour is cascade which is not wanted
            /*foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }*/

            base.OnModelCreating(modelBuilder);
        }
    }
}