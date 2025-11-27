using TechStore.Application.Interfaces;
using TechStore.Domain.Entities;
using TechStore.Infrastructure.Persistence.Data;

namespace TechStore.Infrastructure.Persistence.Repositories
{
    public class CategoryRepository : Repository<CategoryDomain>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext context) : base(context) { }

    }
}
