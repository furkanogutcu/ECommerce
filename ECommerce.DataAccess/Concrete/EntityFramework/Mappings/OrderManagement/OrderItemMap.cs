using ECommerce.Entities.Concrete.OrderManagement;
using ECommerce.Entities.Concrete.ProductManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.DataAccess.Concrete.EntityFramework.Mappings.OrderManagement
{
    public class OrderItemMap : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.ToTable("OrderItems");
            builder.HasKey(o => o.Id);

            builder.Property(o => o.Id).IsRequired();

            builder.Property(o => o.OrderDetailId).IsRequired();
            builder.HasOne<OrderDetail>(o => o.OrderDetail).WithMany().OnDelete(DeleteBehavior.NoAction);

            builder.Property(o => o.ProductId).IsRequired();
            builder.HasOne<Product>(o => o.Product).WithMany().OnDelete(DeleteBehavior.NoAction);

            builder.Property(o => o.OrderItemStatusId).IsRequired();
            builder.HasOne<OrderItemStatus>(o => o.OrderItemStatus).WithMany().OnDelete(DeleteBehavior.NoAction);

            builder.HasIndex(o => new {o.OrderDetailId, o.ProductId}).IsUnique();

            builder.Property(o => o.Quantity).IsRequired();

            builder.Property(o => o.CreatedAt).IsRequired().HasColumnType("datetime2").HasDefaultValueSql("GETDATE()");

            builder.Property(o => o.ModifiedAt).IsRequired(false).HasColumnType("datetime2");
        }
    }
}