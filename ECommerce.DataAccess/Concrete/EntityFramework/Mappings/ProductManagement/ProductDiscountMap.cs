using ECommerce.Entities.Concrete.ProductManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.DataAccess.Concrete.EntityFramework.Mappings.ProductManagement
{
    public class ProductDiscountMap : IEntityTypeConfiguration<ProductDiscount>
    {
        public void Configure(EntityTypeBuilder<ProductDiscount> builder)
        {
            builder.ToTable("ProductDiscounts");
            builder.HasKey(d => d.Id);

            builder.Property(d => d.Id).IsRequired();

            builder.Property(d => d.DiscountName).IsRequired().HasColumnType("nvarchar(250)");

            builder.Property(d => d.Description).IsRequired().HasColumnType("nvarchar(max)");

            builder.Property(d => d.DiscountPercent).IsRequired().HasColumnType("decimal(18,2)");

            builder.Property(d => d.IsActive).IsRequired();

            builder.Property(d => d.CreatedAt).IsRequired().HasColumnType("datetime2").HasDefaultValueSql("GETDATE()");

            builder.Property(d => d.ModifiedAt).IsRequired(false).HasColumnType("datetime2");
        }
    }
}