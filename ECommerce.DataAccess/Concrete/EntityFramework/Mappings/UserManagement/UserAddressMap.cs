using ECommerce.Core.Entities.Concrete;
using ECommerce.Entities.Concrete.UserManagement;
using ECommerce.Entities.Concrete.UserManagement.Address;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.DataAccess.Concrete.EntityFramework.Mappings.UserManagement
{
    public class UserAddressMap : IEntityTypeConfiguration<UserAddress>
    {
        public void Configure(EntityTypeBuilder<UserAddress> builder)
        {
            builder.ToTable("UserAddresses");
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Id).IsRequired();

            builder.Property(a => a.UserId).IsRequired();
            builder.HasOne<User>(a => a.User).WithMany().OnDelete(DeleteBehavior.NoAction);

            builder.Property(a => a.AddressCityId).IsRequired();
            builder.HasOne<AddressCity>(a => a.AddressCity).WithMany().OnDelete(DeleteBehavior.NoAction);

            builder.Property(a => a.Address).IsRequired().HasColumnType("nvarchar(max)");

            builder.Property(a => a.GsmNumber).IsRequired().HasColumnType("nvarchar(25)");

            builder.Property(a => a.CreatedAt).IsRequired().HasColumnType("datetime2").HasDefaultValueSql("GETDATE()");

            builder.Property(a => a.ModifiedAt).IsRequired(false).HasColumnType("datetime2");
        }
    }
}