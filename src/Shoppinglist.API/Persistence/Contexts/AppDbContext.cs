using Microsoft.EntityFrameworkCore;
using Shoppinglist.API.Domain.Models;
using Oracle.EntityFrameworkCore;

namespace Shoppinglist.API.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        

        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {

        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseOracle(@"User Id=hr;Password=hr;Data Source=localhost:1521/xe");
        //}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

                                 
            builder.Entity<Product>().ToTable("Products");
            builder.Entity<Product>().HasKey(p => p.Id);
            builder.Entity<Product>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd().UseOracleIdentityColumn();
            builder.Entity<Product>().Property(p => p.Name).IsRequired().HasMaxLength(50);
            builder.Entity<Product>().Property(p => p.QuantityInPackage).IsRequired();
            builder.Entity<Product>().Property(p => p.UnitOfMeasurement).IsRequired();



            builder.Entity<Product>().HasData
            (
                new Product { Id = 1, Name = "Apple", QuantityInPackage = 5, UnitOfMeasurement = EUnitOfMeasurement.Kilogram },
                new Product { Id = 2, Name = "Milk", QuantityInPackage = 2, UnitOfMeasurement = EUnitOfMeasurement.Liter }
            );

            
        }

    }
}