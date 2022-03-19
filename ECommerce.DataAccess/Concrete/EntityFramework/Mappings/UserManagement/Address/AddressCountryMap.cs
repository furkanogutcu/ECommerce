using ECommerce.Entities.Concrete.UserManagement.Address;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.DataAccess.Concrete.EntityFramework.Mappings.UserManagement.Address
{
    public class AddressCountryMap : IEntityTypeConfiguration<AddressCountry>
    {
        public void Configure(EntityTypeBuilder<AddressCountry> builder)
        {
            builder.ToTable("AddressCountries");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).IsRequired();

            builder.Property(c => c.Name).IsRequired().HasColumnType("nvarchar(250)");

            builder.Property(c => c.Iso3).IsRequired().HasColumnType("nvarchar(250)");

            builder.Property(c => c.Iso2).IsRequired().HasColumnType("nvarchar(250)");

            builder.Property(c => c.NumericCode).IsRequired().HasColumnType("nvarchar(250)");

            builder.Property(c => c.PhoneCode).IsRequired().HasColumnType("nvarchar(250)");

            builder.Property(c => c.Capital).IsRequired(false).HasColumnType("nvarchar(250)");

            builder.Property(c => c.Native).IsRequired(false).HasColumnType("nvarchar(250)");

            builder.Property(c => c.Region).IsRequired(false).HasColumnType("nvarchar(250)");

            builder.Property(c => c.SubRegion).IsRequired(false).HasColumnType("nvarchar(250)");

            builder.Property(c => c.Latitude).IsRequired().HasColumnType("nvarchar(15)");

            builder.Property(c => c.Longitude).IsRequired().HasColumnType("nvarchar(15)");
        }
    }
}