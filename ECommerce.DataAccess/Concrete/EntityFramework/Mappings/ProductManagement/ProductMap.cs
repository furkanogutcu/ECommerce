using ECommerce.Entities.Concrete.ProductManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.DataAccess.Concrete.EntityFramework.Mappings.ProductManagement
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).IsRequired();

            builder.Property(p => p.ProductCategoryId).IsRequired();
            builder.HasOne<ProductCategory>(p => p.ProductCategory).WithMany().OnDelete(DeleteBehavior.NoAction);

            builder.Property(p => p.ProductInventoryId).IsRequired();
            builder.HasOne<ProductInventory>(p => p.ProductInventory).WithOne().OnDelete(DeleteBehavior.NoAction);

            builder.Property(p => p.ProductDiscountId).IsRequired(false);
            builder.HasOne<ProductDiscount>(p => p.ProductDiscount).WithMany().OnDelete(DeleteBehavior.NoAction);

            builder.Property(p => p.ProductName).IsRequired().HasColumnType("nvarchar(250)");

            builder.Property(p => p.Description).IsRequired().HasColumnType("nvarchar(max)");

            builder.Property(p => p.UnitPrice).IsRequired().HasColumnType("decimal(18,2)");

            builder.Property(p => p.IsActive).IsRequired();

            builder.Property(p => p.CreatedAt).IsRequired().HasColumnType("datetime2").HasDefaultValueSql("GETDATE()");

            builder.Property(p => p.ModifiedAt).IsRequired(false).HasColumnType("datetime2");

            builder.Property(p => p.DeletedAt).IsRequired(false).HasColumnType("datetime2");
        }
    }
}