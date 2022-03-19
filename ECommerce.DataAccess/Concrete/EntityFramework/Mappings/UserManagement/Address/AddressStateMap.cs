using ECommerce.Entities.Concrete.UserManagement.Address;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.DataAccess.Concrete.EntityFramework.Mappings.UserManagement.Address
{
    public class AddressStateMap : IEntityTypeConfiguration<AddressState>
    {
        public void Configure(EntityTypeBuilder<AddressState> builder)
        {
            builder.ToTable("AddressStates");
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Id).IsRequired();

            builder.Property(s => s.AddressCountryId).IsRequired();
            builder.HasOne<AddressCountry>(s => s.AddressCountry).WithMany().OnDelete(DeleteBehavior.NoAction);

            builder.Property(s => s.Name).IsRequired().HasColumnType("nvarchar(250)");

            builder.Property(s => s.StateCode).IsRequired().HasColumnType("nvarchar(250)");

            builder.Property(s => s.Latitude).IsRequired(false).HasColumnType("nvarchar(15)");

            builder.Property(s => s.Longitude).IsRequired(false).HasColumnType("nvarchar(15)");
        }
    }
}