using Microsoft.EntityFrameworkCore;
using TechStore.Domain.Entities;
using TechStore.Infrastructure.Persistence.Data;
using TechStore.Infrastructure.Persistence.Repositories;

namespace TechStore.Tests
{
    public class ProductRepositoryTests
    {
        private readonly DbContextOptions<ApplicationDbContext> _options;

        public ProductRepositoryTests()
        {
            _options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("Default")
                .Options;
        }
        private ApplicationDbContext CreateDbContext() => new ApplicationDbContext(_options);

        [Fact]
        public async Task AddAsync_ShouldAddProduct()
        {
            var db = CreateDbContext();

            var repo = new ProductRepository(db);

            var product = new ProductDomain
            {
                Id = 1,
                ProductName = "IPhone 14",
                ProductDescription = "Description",
                Price = 899,
                CategoryId = 1,
                Inventory = 53,
                Version = new byte[8]
            };

            await repo.Add(product);

            var result = await
                db.Products.SingleOrDefaultAsync(x => x.ProductName == "IPhone 14");

            Assert.NotNull(result);
            Assert.Equal("IPhone 14", result.ProductName);
        }

        [Fact]
        public async Task GetAllAsync_ShouldGetAllProducts()
        {
            var db = CreateDbContext();

            var repo = new ProductRepository(db);

            var products = new List<ProductDomain>()
            {
                new ProductDomain
                {
                    Id = 1,
                    ProductName = "Test1",
                    ProductDescription = "Test1",
                    Price = 199,
                    Inventory =12,
                    CategoryId = 1,
                    Version = new byte[8]

                },
                new ProductDomain
                {
                    Id = 2,
                    ProductName = "Test2",
                    ProductDescription = "Test2",
                    Price = 299,
                    Inventory = 20,
                    CategoryId = 1,
                    Version = new byte[10]

                },
            };

            await db.Products.AddRangeAsync(products);
            await db.SaveChangesAsync();

            var results = await repo.GetAllAsync();

            Assert.NotNull(results);

            Assert.Equal(2, results.Count);
        }

        [Fact]
        public async Task GetByIdAsync_ShouldGetByIdProduct()
        {
            var db = CreateDbContext();

            var repo = new ProductRepository(db);

            var products = new List<ProductDomain>()
            {
                new ProductDomain
                {
                    Id = 1,
                    ProductName = "Test1",
                    ProductDescription = "Test1",
                    Price = 199,
                    Inventory =12,
                    CategoryId = 1,
                    Version = new byte[8]

                },
                new ProductDomain
                {
                    Id = 2,
                    ProductName = "Test2",
                    ProductDescription = "Test2",
                    Price = 299,
                    Inventory = 20,
                    CategoryId = 1,
                    Version = new byte[10]

                },
            };

            await db.Products.AddRangeAsync(products);
            await db.SaveChangesAsync();


            var result = await repo.GetByIdAsync(2);

            Assert.NotNull(result);
            Assert.Equal("Test2", result.ProductName);

        }

        // update repo method implements in CQRS pattern.

        [Fact]
        public async Task DeleteAsync_ShouldDeleteProduct()
        {
            var db = CreateDbContext();

            var repo = new ProductRepository(db);

            var products = new List<ProductDomain>()
            {
                new ProductDomain
                {
                    Id = 1,
                    ProductName = "Test1",
                    ProductDescription = "Test1",
                    Price = 199,
                    Inventory =12,
                    CategoryId = 1,
                    Version = new byte[8]

                },
                new ProductDomain
                {
                    Id = 2,
                    ProductName = "Test2",
                    ProductDescription = "Test2",
                    Price = 299,
                    Inventory = 20,
                    CategoryId = 1,
                    Version = new byte[10]

                },
            };

            await db.Products.AddRangeAsync(products);
            await db.SaveChangesAsync();

            await repo.Delete(products[1]);

            var result = await db.Products.ToListAsync();

            Assert.NotNull(result);

            Assert.NotEqual(2, result.Count);

            Assert.Equal(199, result[0].Price);
        }
    }
}
