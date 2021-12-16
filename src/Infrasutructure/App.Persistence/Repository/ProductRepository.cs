using App.Persistence.Context;
using App.Persistence.Repository;
using Application.Interfaces.Repositoy;
using Domain.Entities;

namespace Persistence.Repository
{
    public class ProductRepository:GenericRepository<Product>,IProductRepository
    {
        public ProductRepository(AppDbContext dbContext):base(dbContext)
        {

        }
    }
}
