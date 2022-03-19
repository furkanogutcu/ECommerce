using ECommerce.Core.Entities.Concrete;
using ECommerce.DataAccess.Concrete.EntityFramework.Mappings.OrderManagement;
using ECommerce.DataAccess.Concrete.EntityFramework.Mappings.ProductManagement;
using ECommerce.DataAccess.Concrete.EntityFramework.Mappings.UserManagement;
using ECommerce.DataAccess.Concrete.EntityFramework.Mappings.UserManagement.Address;
using ECommerce.Entities.Concrete.OrderManagement;
using ECommerce.Entities.Concrete.ProductManagement;
using ECommerce.Entities.Concrete.UserManagement;
using ECommerce.Entities.Concrete.UserManagement.Address;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.DataAccess.Concrete.EntityFramework
{
    public class ECommerceContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ECommerce;Trusted_Connection=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ApplyConfigurations(modelBuilder);
            ApplyAutoIncludes(modelBuilder);
        }

        //Order Management Entities
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<OrderItemStatus> OrderItemStatuses { get; set; }
        public DbSet<PaymentDetail> PaymentDetails { get; set; }
        public DbSet<ShoppingSession> ShoppingSessions { get; set; }

        //Product Management Entities
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductDiscount> ProductDiscounts { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductInventory> ProductInventories { get; set; }

        //User Management Entities
        public DbSet<User> Users { get; set; }
        public DbSet<UserAddress> UserAddresses { get; set; }
        public DbSet<AddressCity> AddressCities { get; set; }
        public DbSet<AddressCountry> AddressCountries { get; set; }
        public DbSet<AddressState> AddressStates { get; set; }
        public DbSet<UserCreditCard> UserCreditCards { get; set; }  //Simulation Property
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

        //Private Methods

        private static void ApplyConfigurations(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CartItemMap());
            modelBuilder.ApplyConfiguration(new OrderDetailMap());
            modelBuilder.ApplyConfiguration(new OrderItemMap());
            modelBuilder.ApplyConfiguration(new OrderItemStatusMap());
            modelBuilder.ApplyConfiguration(new PaymentDetailMap());
            modelBuilder.ApplyConfiguration(new ShoppingSessionMap());
            modelBuilder.ApplyConfiguration(new ProductMap());
            modelBuilder.ApplyConfiguration(new ProductCategoryMap());
            modelBuilder.ApplyConfiguration(new ProductDiscountMap());
            modelBuilder.ApplyConfiguration(new ProductImageMap());
            modelBuilder.ApplyConfiguration(new ProductInventoryMap());
            modelBuilder.ApplyConfiguration(new OperationClaimMap());
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new UserOperationClaimMap());
            modelBuilder.ApplyConfiguration(new UserAddressMap());
            modelBuilder.ApplyConfiguration(new AddressCityMap());
            modelBuilder.ApplyConfiguration(new AddressCountryMap());
            modelBuilder.ApplyConfiguration(new AddressStateMap());
            modelBuilder.ApplyConfiguration(new UserCreditCardMap());
        }

        private static void ApplyAutoIncludes(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CartItem>().Navigation(c => c.ShoppingSession).AutoInclude();
            modelBuilder.Entity<CartItem>().Navigation(c => c.Product).AutoInclude();
            modelBuilder.Entity<OrderDetail>().Navigation(o => o.User).AutoInclude();
            modelBuilder.Entity<OrderDetail>().Navigation(o => o.PaymentDetail).AutoInclude();
            modelBuilder.Entity<OrderItem>().Navigation(o => o.OrderDetail).AutoInclude();
            modelBuilder.Entity<OrderItem>().Navigation(o => o.Product).AutoInclude();
            modelBuilder.Entity<OrderItem>().Navigation(o => o.OrderItemStatus).AutoInclude();
            modelBuilder.Entity<ShoppingSession>().Navigation(s => s.User).AutoInclude();
            modelBuilder.Entity<Product>().Navigation(p => p.ProductCategory).AutoInclude();
            modelBuilder.Entity<Product>().Navigation(p => p.ProductInventory).AutoInclude();
            modelBuilder.Entity<Product>().Navigation(p => p.ProductDiscount).AutoInclude();
            modelBuilder.Entity<ProductImage>().Navigation(p => p.Product).AutoInclude();
            modelBuilder.Entity<UserOperationClaim>().Navigation(u => u.User).AutoInclude();
            modelBuilder.Entity<UserOperationClaim>().Navigation(u => u.OperationClaim).AutoInclude();
            modelBuilder.Entity<UserAddress>().Navigation(a => a.User).AutoInclude();
            modelBuilder.Entity<UserAddress>().Navigation(a => a.AddressCity).AutoInclude();
            modelBuilder.Entity<AddressCity>().Navigation(c => c.AddressState).AutoInclude();
            modelBuilder.Entity<AddressState>().Navigation(s => s.AddressCountry).AutoInclude();
            modelBuilder.Entity<UserCreditCard>().Navigation(c => c.User).AutoInclude();
        }
    }
}
