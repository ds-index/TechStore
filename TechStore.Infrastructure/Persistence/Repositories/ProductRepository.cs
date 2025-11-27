using TechStore.Application.Interfaces;
using TechStore.Domain.Entities;
using TechStore.Infrastructure.Persistence.Data;

namespace TechStore.Infrastructure.Persistence.Repositories
{
    public class ProductRepository : Repository<ProductDomain>,  IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) : base(context) { }
    }
}
