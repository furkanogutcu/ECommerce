using ECommerce.Core.Entities.Concrete;
using ECommerce.Entities.Concrete.OrderManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.DataAccess.Concrete.EntityFramework.Mappings.OrderManagement
{
    public class ShoppingSessionMap : IEntityTypeConfiguration<ShoppingSession>
    {
        public void Configure(EntityTypeBuilder<ShoppingSession> builder)
        {
            builder.ToTable("ShoppingSessions");
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Id).IsRequired();

            builder.Property(s => s.UserId).IsRequired();
            builder.HasOne<User>(s => s.User).WithOne().OnDelete(DeleteBehavior.NoAction);

            builder.Property(s => s.Total).IsRequired().HasColumnType("decimal(18,2)");

            builder.Property(s => s.CreatedAt).IsRequired().HasColumnType("datetime2").HasDefaultValueSql("GETDATE()");

            builder.Property(s => s.ModifiedAt).IsRequired(false).HasColumnType("datetime2");
        }
    }
}