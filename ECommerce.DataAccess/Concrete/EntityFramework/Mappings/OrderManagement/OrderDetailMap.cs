using ECommerce.Core.Entities.Concrete;
using ECommerce.Entities.Concrete.OrderManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.DataAccess.Concrete.EntityFramework.Mappings.OrderManagement
{
    public class OrderDetailMap : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable("OrderDetails");
            builder.HasKey(o => o.Id);

            builder.Property(o => o.Id).IsRequired();

            builder.Property(o => o.UserId).IsRequired();
            builder.HasOne<User>(o => o.User).WithMany().OnDelete(DeleteBehavior.NoAction);

            builder.Property(o => o.PaymentDetailId).IsRequired();
            builder.HasOne<PaymentDetail>(o => o.PaymentDetail).WithOne().OnDelete(DeleteBehavior.NoAction);

            builder.Property(o => o.Total).IsRequired().HasColumnType("decimal(18,2)");

            builder.Property(o => o.CreatedAt).IsRequired().HasColumnType("datetime2").HasDefaultValueSql("GETDATE()");

            builder.Property(o => o.ModifiedAt).IsRequired(false).HasColumnType("datetime2");
        }
    }
}