using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechStore.Domain.Entities;

namespace TechStore.Infrastructure.Persistence.Configs
{
    public class CategoryConfig : IEntityTypeConfiguration<CategoryDomain>
    {
        public void Configure(EntityTypeBuilder<CategoryDomain> builder)
        {
            var categories = new List<CategoryDomain>
            {
                new CategoryDomain { Id = 1, CategoryName = "Smartphones", CategoryDescription = "Mobile phones and smart devices" },
                new CategoryDomain { Id = 2, CategoryName = "Laptops", CategoryDescription = "Portable computers and notebooks" },
                new CategoryDomain { Id = 3, CategoryName = "Tablets", CategoryDescription = "Touch-based portable devices" },
                new CategoryDomain { Id = 4, CategoryName = "Smart Watches", CategoryDescription = "Wearable smart devices" },
                new CategoryDomain { Id = 5, CategoryName = "Headphones", CategoryDescription = "Audio devices and earphones" },
                new CategoryDomain { Id = 6, CategoryName = "Gaming Consoles", CategoryDescription = "Devices for gaming and entertainment" },
                new CategoryDomain { Id = 7, CategoryName = "Accessories", CategoryDescription = "Tech accessories and peripherals" }
            };

            builder.HasIndex(x => x.Id)
                .IsUnique();

            builder.Property(x => x.Version)
                .IsConcurrencyToken()
                .IsRowVersion();

            builder.HasData(categories);

        }
    }
}
