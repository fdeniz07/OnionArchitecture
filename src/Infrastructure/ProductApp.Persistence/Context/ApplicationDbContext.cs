using Microsoft.EntityFrameworkCore;
using ProductApp.Domain.Entities;

namespace ProductApp.Persistence.Context
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Product> Products { get; set; }

        #region Overrides of DbContext

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Product>().HasData(
                new Product() {Id=Guid.NewGuid(),Name = "Pen", Value = 10, Quantity = 100},
                new Product() { Id = Guid.NewGuid(), Name = "Paper A4", Value = 1, Quantity = 200 },
                new Product() { Id = Guid.NewGuid(), Name = "Book", Value = 30, Quantity = 5000 });


            base.OnModelCreating(modelBuilder);
        }

        #endregion
    }
}
