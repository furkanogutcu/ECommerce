using ECommerce.Core.Entities.Concrete;
using ECommerce.Entities.Concrete.UserManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.DataAccess.Concrete.EntityFramework.Mappings.UserManagement
{
    //Simulation Class
    public class UserCreditCardMap : IEntityTypeConfiguration<UserCreditCard>
    {
        public void Configure(EntityTypeBuilder<UserCreditCard> builder)
        {
            builder.ToTable("UserCreditCards");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).IsRequired();

            builder.Property(c => c.UserId).IsRequired();
            builder.HasOne<User>(c => c.User).WithMany().OnDelete(DeleteBehavior.NoAction);

            builder.Property(c => c.CardHolderName).IsRequired().HasColumnType("nvarchar(250)");

            builder.Property(c => c.AccountNumberHash).IsRequired().HasColumnType("varbinary(1000)");

            builder.Property(c => c.AccountNumberSalt).IsRequired().HasColumnType("varbinary(1000)");

            builder.Property(c => c.ExpireMonth).IsRequired();

            builder.Property(c => c.ExpireYear).IsRequired();

            builder.Property(c => c.CvcHash).IsRequired().HasColumnType("varbinary(1000)");

            builder.Property(c => c.CvcSalt).IsRequired().HasColumnType("varbinary(1000)");

            builder.Property(c => c.CreatedAt).IsRequired().HasColumnType("datetime2").HasDefaultValueSql("GETDATE()");

            builder.Property(c => c.ModifiedAt).IsRequired(false).HasColumnType("datetime2");
        }
    }
}