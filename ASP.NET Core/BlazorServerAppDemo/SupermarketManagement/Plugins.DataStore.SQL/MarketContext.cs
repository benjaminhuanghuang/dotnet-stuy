using CoreBusiness;
using Microsoft.EntityFrameworkCore;

namespace Plugins.DataStore.SQL
{
    public class MarketContext : DbContext
    {
        public MarketContext(DbContextOptions<MarketContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Transaction> Transactions { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>()
                .HasMany(c => c.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId);

            // Seeding some data
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Category 1", Description = "Description 1" },
                new Category { CategoryId = 2, Name = "Category 2", Description = "Description 2" },
                new Category { CategoryId = 3, Name = "Category 3", Description = "Description 3" }
            );

            modelBuilder.Entity<Product>().HasData(
               new Product { ProductId = 1, CategoryId = 1, Name = "Iced Tea", Quantity = 100, Price = 1.99 },
               new Product { ProductId = 2, CategoryId = 1, Name = "Iced Tea1", Quantity = 100, Price = 1.99 },
               new Product { ProductId = 3, CategoryId = 2, Name = "addccccc1", Quantity = 100, Price = 1.99 },
               new Product { ProductId = 4, CategoryId = 2, Name = "addccccc2", Quantity = 100, Price = 1.99 }
           );

        }
    }
}