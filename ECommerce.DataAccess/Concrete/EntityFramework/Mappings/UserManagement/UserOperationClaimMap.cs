using ECommerce.Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.DataAccess.Concrete.EntityFramework.Mappings.UserManagement
{
    public class UserOperationClaimMap : IEntityTypeConfiguration<UserOperationClaim>
    {
        public void Configure(EntityTypeBuilder<UserOperationClaim> builder)
        {
            builder.ToTable("UserOperationClaims");
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Id).IsRequired();

            builder.Property(u => u.UserId).IsRequired();
            builder.HasOne<User>(u => u.User).WithMany().OnDelete(DeleteBehavior.NoAction);

            builder.Property(u => u.OperationClaimId).IsRequired();
            builder.HasOne<OperationClaim>(u => u.OperationClaim).WithMany().OnDelete(DeleteBehavior.NoAction);

            builder.Property(u => u.CreatedAt).IsRequired().HasColumnType("datetime2").HasDefaultValueSql("GETDATE()");

            builder.Property(u => u.ModifiedAt).IsRequired(false).HasColumnType("datetime2");
        }
    }
}