using ECommerce.Entities.Concrete.OrderManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.DataAccess.Concrete.EntityFramework.Mappings.OrderManagement
{
    public class PaymentDetailMap : IEntityTypeConfiguration<PaymentDetail>
    {
        public void Configure(EntityTypeBuilder<PaymentDetail> builder)
        {
            builder.ToTable("PaymentDetails");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).IsRequired();

            builder.Property(p => p.Amount).IsRequired().HasColumnType("decimal(18,2)");

            builder.Property(p => p.Status).IsRequired();

            builder.Property(p => p.CreatedAt).IsRequired().HasColumnType("datetime2").HasDefaultValueSql("GETDATE()");

            builder.Property(p => p.ModifiedAt).IsRequired(false).HasColumnType("datetime2");
        }
    }
}