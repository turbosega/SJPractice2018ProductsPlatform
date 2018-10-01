using System;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using System.Linq;

using DAL.Entities;

namespace DAL
{
    public class StoreContext : DbContext
    {
        public DbSet <Product> Products { get; set; }

        // dotnet ef migrations add migrationname
        public StoreContext(DbContextOptions<StoreContext> options) :base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelbBuilder)
        {
            //default delete behaviour is cascade which is not wanted
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            base.OnModelCreating(modelbBuilder);
        }
    }
}