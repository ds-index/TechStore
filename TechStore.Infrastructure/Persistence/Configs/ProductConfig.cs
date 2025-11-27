using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechStore.Domain.Entities;
using TechStore.Infrastructure.Services;

namespace TechStore.Infrastructure.Persistence.Configs
{
    public class ProductConfig : IEntityTypeConfiguration<ProductDomain>
    {
        public void Configure(EntityTypeBuilder<ProductDomain> builder)
        {
            builder.HasIndex(x => x.Id)
                .IsUnique();

            builder.HasQueryFilter(x => !x.IsDeleted);

            builder.HasOne(x => x.Category)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.Version)
                .IsConcurrencyToken()
                .IsRowVersion();

            builder.HasData(
                ProductsSeeder.Gen()
                );


        }
    }
}
