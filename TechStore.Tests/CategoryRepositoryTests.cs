using Microsoft.EntityFrameworkCore;
using TechStore.Domain.Entities;
using TechStore.Infrastructure.Persistence.Data;
using TechStore.Infrastructure.Persistence.Repositories;

namespace TechStore.Tests
{
    public class CategoryRepositoryTests
    {
        private readonly DbContextOptions<ApplicationDbContext> _options;

        public CategoryRepositoryTests()
        {
            _options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("Default")
                .Options;
        }

        private ApplicationDbContext CreateDb() => new ApplicationDbContext(_options);

        [Fact]
        public async Task AddAsync_ShouldAddCategory()
        {
            var db = CreateDb();

            var repo = new CategoryRepository(db);

            var category = new CategoryDomain
            {
                Id = 1,
                CategoryName = "Tech",
                CategoryDescription = "This is test category",
                Version = new byte[8]
            };

            await repo.Add(category);

            var result = await db.Categories.SingleOrDefaultAsync(x => x.CategoryName == "Tech");

            Assert.NotNull(result);

            Assert.Equal("Tech", result.CategoryName);

        }

        [Fact]
        public async Task GetAllAsync_ShouldGetAllCategories()
        {
            var db = CreateDb();

            var repo = new CategoryRepository(db);

            var categories = new List<CategoryDomain>()
            {
                new CategoryDomain
                {
                    Id = 1,
                    CategoryName = "Tech",
                    CategoryDescription = "Test1",
                    Version = new byte[8]
                },

                new CategoryDomain
                {
                    Id = 2,
                    CategoryName = "Local",
                    CategoryDescription = "Test2",
                    Version = new byte[8]
                }
            };

            await db.Categories.AddRangeAsync(categories);
            await db.SaveChangesAsync();

            var result = await repo.GetAllAsync();

            Assert.NotNull(result);

            Assert.Equal(2, result.Count);

            Assert.Equal("Local", result[1].CategoryName);
        }

        [Fact]
        public async Task GetByIdAsync_ShouldGetByIdCategory()
        {
            var db = CreateDb();

            var repo = new CategoryRepository(db);

            var categories = new List<CategoryDomain>()
            {
                new CategoryDomain
                {
                    Id = 1,
                    CategoryName = "Tech",
                    CategoryDescription = "Test1",
                    Version = new byte[8]
                },

                new CategoryDomain
                {
                    Id = 2,
                    CategoryName = "Local",
                    CategoryDescription = "Test2",
                    Version = new byte[10]
                }
            };

            await db.Categories.AddRangeAsync(categories);


            var category = await repo.GetByIdAsync(1);

            Assert.NotNull(category);
            Assert.Equal("Test1", category.CategoryDescription);
        }

        // update repo method implements in CQRS pattern.

        [Fact]
        public async Task DeleteAsync_ShouldDeleteCategory()
        {
            var db = CreateDb();

            var repo = new CategoryRepository(db);

            var category1 = new CategoryDomain
            {
                Id = 1,
                CategoryName = "Test1",
                CategoryDescription = "Test1",
                Version = new byte[8]
            };

            var category2 = new CategoryDomain
            {
                Id = 2,
                CategoryName = "Test2",
                CategoryDescription = "Test2",
                Version = new byte[10]
            };

            await repo.Add(category1);
            await repo.Add(category2);


            await repo.Delete(category2);

            var categories = await db.Categories.ToListAsync();


            Assert.NotNull(categories);

            Assert.NotEqual(2, categories.Count);

            //await Assert.ThrowsAsync<KeyNotFoundException>(async () => await repo.GetByIdAsync(2));
        }
    }
}
