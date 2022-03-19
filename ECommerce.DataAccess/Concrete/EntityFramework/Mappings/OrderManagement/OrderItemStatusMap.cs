using ECommerce.Entities.Concrete.OrderManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.DataAccess.Concrete.EntityFramework.Mappings.OrderManagement
{
    public class OrderItemStatusMap : IEntityTypeConfiguration<OrderItemStatus>
    {
        public void Configure(EntityTypeBuilder<OrderItemStatus> builder)
        {
            builder.ToTable("OrderItemStatuses");
            builder.HasKey(o => o.Id);

            builder.Property(o => o.Id).IsRequired();

            builder.Property(o => o.Status).IsRequired().HasColumnType("nvarchar(max)");
        }
    }
}