using ECommerce.Entities.Concrete.ProductManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.DataAccess.Concrete.EntityFramework.Mappings.ProductManagement
{
    public class ProductCategoryMap : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.ToTable("ProductCategories");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).IsRequired();

            builder.Property(c => c.CategoryName).IsRequired().HasColumnType("nvarchar(250)");

            builder.Property(c => c.Description).IsRequired().HasColumnType("nvarchar(max)");

            builder.Property(c => c.IsActive).IsRequired();

            builder.Property(c => c.CreatedAt).IsRequired().HasColumnType("datetime2").HasDefaultValueSql("GETDATE()");

            builder.Property(c => c.ModifiedAt).IsRequired(false).HasColumnType("datetime2");
        }
    }
}