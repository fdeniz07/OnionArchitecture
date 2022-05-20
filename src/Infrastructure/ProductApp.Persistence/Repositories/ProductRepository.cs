using ProductApp.Application.Interfaces.Repository;
using ProductApp.Domain.Entities;
using ProductApp.Persistence.Context;

namespace ProductApp.Persistence.Repositories
{
    public class ProductRepository :GenericRepository<Product>,IProductRepository
    {
        public ProductRepository(ApplicationDbContext dbContext):base(dbContext)
        {
        }
    }
}
