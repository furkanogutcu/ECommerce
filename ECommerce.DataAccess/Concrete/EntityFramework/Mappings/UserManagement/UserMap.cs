using ECommerce.Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.DataAccess.Concrete.EntityFramework.Mappings.UserManagement
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Id).IsRequired();

            builder.Property(u => u.FirstName).IsRequired().HasColumnType("nvarchar(100)");

            builder.Property(u => u.LastName).IsRequired().HasColumnType("nvarchar(100)");

            builder.Property(u => u.Email).IsRequired().HasColumnType("nvarchar(100)");
            builder.HasIndex(u => u.Email).IsUnique();

            builder.Property(u => u.GsmNumber).IsRequired().HasColumnType("nvarchar(25)");

            builder.Property(u => u.PasswordHash).IsRequired().HasColumnType("varbinary(1000)");

            builder.Property(u => u.PasswordSalt).IsRequired().HasColumnType("varbinary(1000)");

            builder.Property(u => u.Status).IsRequired();

            builder.Property(u => u.CreatedAt).IsRequired().HasColumnType("datetime2").HasDefaultValueSql("GETDATE()");

            builder.Property(u => u.ModifiedAt).IsRequired(false).HasColumnType("datetime2");

            builder.Property(u => u.DeletedAt).IsRequired(false).HasColumnType("datetime2");
        }
    }
}