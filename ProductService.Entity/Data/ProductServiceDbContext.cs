using Microsoft.EntityFrameworkCore;
using ProductService.Entity.Entity;
using ProductService.Entity.Entity.Product;
using ProductService.Entity.Entity.Warehouse;
using System.Reflection.Emit;

namespace ProductService.Entity.Data
{
    public class ProductServiceDbContext : DbContext
    {
        public ProductServiceDbContext(DbContextOptions<ProductServiceDbContext> options) : base(options)
        {

        }
        public DbSet<Batch> Batch { get; set; }
        
        public DbSet<Product> Products { get; set; }
        
        public DbSet<ContactPersons> ContactPersons { get; set; }
        public DbSet<Emails> Emails { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<WarehouseSummary> WarehouseSummary { get; set; }
        public DbSet<Warehouse> Warehouse { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Batch>().ToTable("Batchs"); 
            modelBuilder.Entity<DataFile>().ToTable("DataFile"); 
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<ContactPersons>().ToTable("ContactPersons");
            modelBuilder.Entity<Emails>().ToTable("Emails");
            modelBuilder.Entity<Location>().ToTable("Location");
            modelBuilder.Entity<WarehouseSummary>().ToTable("WarehouseSummary");
            modelBuilder.Entity<Warehouse>().ToTable("Warehouse");
        }
    }
}
