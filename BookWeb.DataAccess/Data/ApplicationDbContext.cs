using BookWeb.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace BookWeb.DataAccess.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
            base(options)
        {

        }
        
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Action", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Action", DisplayOrder = 3 }

                );
            modelBuilder.Entity<Product>().HasData(
               new Product { Id = 1, Title = "Book 1",Description="test1" ,ISBN="929340",Author = "Author test",ListPrice=100 },
               new Product { Id = 2, Title = "Book 2", Description = "test2", ISBN = "929341", Author = "Author test2", ListPrice = 110 },
               new Product { Id = 3, Title = "Book 3", Description = "test3", ISBN = "929342", Author = "Author test3", ListPrice = 50 }

               );
        }
    }
}
