using ECommerce.Entities.Concrete.UserManagement.Address;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.DataAccess.Concrete.EntityFramework.Mappings.UserManagement.Address
{
    public class AddressCityMap : IEntityTypeConfiguration<AddressCity>
    {
        public void Configure(EntityTypeBuilder<AddressCity> builder)
        {
            builder.ToTable("AddressCities");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).IsRequired();

            builder.Property(c => c.AddressStateId).IsRequired();
            builder.HasOne<AddressState>(c => c.AddressState).WithMany().OnDelete(DeleteBehavior.NoAction);

            builder.Property(c => c.Name).IsRequired().HasColumnType("nvarchar(250)");

            builder.Property(c => c.Latitude).IsRequired().HasColumnType("nvarchar(15)");

            builder.Property(c => c.Longitude).IsRequired().HasColumnType("nvarchar(15)");
        }
    }
}