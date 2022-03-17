using ECommerce.Core.Entities.Concrete;
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
    }
}
