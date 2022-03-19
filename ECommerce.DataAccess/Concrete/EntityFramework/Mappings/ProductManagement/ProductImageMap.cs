using ECommerce.Entities.Concrete.ProductManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.DataAccess.Concrete.EntityFramework.Mappings.ProductManagement
{
    public class ProductImageMap : IEntityTypeConfiguration<ProductImage>
    {
        public void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            builder.ToTable("ProductImages");
            builder.HasKey(i => i.Id);

            builder.Property(i => i.Id).IsRequired();

            builder.Property(i => i.ProductId).IsRequired();
            builder.HasOne<Product>(i => i.Product).WithMany().OnDelete(DeleteBehavior.NoAction);

            builder.Property(i => i.ImagePath).IsRequired().HasColumnType("nvarchar(max)");

            builder.Property(i => i.IsActive).IsRequired();

            builder.Property(i => i.CreatedAt).IsRequired().HasColumnType("datetime2").HasDefaultValueSql("GETDATE()");

            builder.Property(i => i.ModifiedAt).IsRequired(false).HasColumnType("datetime2");
        }
    }
}