using ECommerce.Entities.Concrete.OrderManagement;
using ECommerce.Entities.Concrete.ProductManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.DataAccess.Concrete.EntityFramework.Mappings.OrderManagement
{
    public class CartItemMap : IEntityTypeConfiguration<CartItem>
    {
        public void Configure(EntityTypeBuilder<CartItem> builder)
        {
            builder.ToTable("CartItems");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).IsRequired();

            builder.Property(c => c.ShoppingSessionId).IsRequired();
            builder.HasOne<ShoppingSession>(c => c.ShoppingSession).WithMany().OnDelete(DeleteBehavior.NoAction);

            builder.Property(c => c.ProductId).IsRequired();
            builder.HasOne<Product>(c => c.Product).WithMany().OnDelete(DeleteBehavior.NoAction);

            builder.HasIndex(c => new {c.ShoppingSessionId, c.ProductId}).IsUnique();

            builder.Property(c => c.Quantity).IsRequired();

            builder.Property(c => c.CreatedAt).IsRequired().HasColumnType("datetime2").HasDefaultValueSql("GETDATE()");

            builder.Property(c => c.ModifiedAt).IsRequired(false).HasColumnType("datetime2");
        }
    }
}