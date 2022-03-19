using ECommerce.Entities.Concrete.ProductManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.DataAccess.Concrete.EntityFramework.Mappings.ProductManagement
{
    public class ProductInventoryMap : IEntityTypeConfiguration<ProductInventory>
    {
        public void Configure(EntityTypeBuilder<ProductInventory> builder)
        {
            builder.ToTable("ProductInventories");
            builder.HasKey(i => i.Id);

            builder.Property(i => i.Id).IsRequired();

            builder.Property(i => i.UnitsInStock).IsRequired();

            builder.Property(i => i.UnitsOnOrder).IsRequired();

            builder.Property(i => i.QuantityPerUnit).IsRequired().HasColumnType("nvarchar(100)");

            builder.Property(i => i.IsActive).IsRequired();

            builder.Property(i => i.CreatedAt).IsRequired().HasColumnType("datetime2").HasDefaultValueSql("GETDATE()");

            builder.Property(i => i.ModifiedAt).IsRequired(false).HasColumnType("datetime2");
        }
    }
}