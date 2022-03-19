﻿// <auto-generated />
using System;
using ECommerce.DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ECommerce.DataAccess.Migrations
{
    [DbContext(typeof(ECommerceContext))]
    [Migration("20220319114743_InitDbECommerce")]
    partial class InitDbECommerce
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ECommerce.Core.Entities.Concrete.OperationClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("OperationClaims");
                });

            modelBuilder.Entity("ECommerce.Core.Entities.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("GsmNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(1000)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(1000)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ECommerce.Core.Entities.Concrete.UserOperationClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("OperationClaimId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OperationClaimId");

                    b.HasIndex("UserId");

                    b.ToTable("UserOperationClaims");
                });

            modelBuilder.Entity("ECommerce.Entities.Concrete.OrderManagement.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("ShoppingSessionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("ShoppingSessionId", "ProductId")
                        .IsUnique();

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("ECommerce.Entities.Concrete.OrderManagement.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("PaymentDetailId")
                        .HasColumnType("int");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PaymentDetailId")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("ECommerce.Entities.Concrete.OrderManagement.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderDetailId")
                        .HasColumnType("int");

                    b.Property<int>("OrderItemStatusId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderItemStatusId");

                    b.HasIndex("ProductId");

                    b.HasIndex("OrderDetailId", "ProductId")
                        .IsUnique();

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("ECommerce.Entities.Concrete.OrderManagement.OrderItemStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OrderItemStatuses");
                });

            modelBuilder.Entity("ECommerce.Entities.Concrete.OrderManagement.PaymentDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("PaymentDetails");
                });

            modelBuilder.Entity("ECommerce.Entities.Concrete.OrderManagement.ShoppingSession", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("ShoppingSessions");
                });

            modelBuilder.Entity("ECommerce.Entities.Concrete.ProductManagement.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductCategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductDiscountId")
                        .HasColumnType("int");

                    b.Property<int>("ProductInventoryId")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("ProductCategoryId");

                    b.HasIndex("ProductDiscountId");

                    b.HasIndex("ProductInventoryId")
                        .IsUnique();

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ECommerce.Entities.Concrete.ProductManagement.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("ECommerce.Entities.Concrete.ProductManagement.ProductDiscount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiscountName")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<decimal>("DiscountPercent")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ProductDiscounts");
                });

            modelBuilder.Entity("ECommerce.Entities.Concrete.ProductManagement.ProductImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImages");
                });

            modelBuilder.Entity("ECommerce.Entities.Concrete.ProductManagement.ProductInventory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("QuantityPerUnit")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("UnitsInStock")
                        .HasColumnType("int");

                    b.Property<int>("UnitsOnOrder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ProductInventories");
                });

            modelBuilder.Entity("ECommerce.Entities.Concrete.UserManagement.Address.AddressCity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddressStateId")
                        .HasColumnType("int");

                    b.Property<string>("Latitude")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Longitude")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.HasIndex("AddressStateId");

                    b.ToTable("AddressCities");
                });

            modelBuilder.Entity("ECommerce.Entities.Concrete.UserManagement.Address.AddressCountry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Capital")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Iso2")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Iso3")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Latitude")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Longitude")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Native")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("NumericCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("PhoneCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Region")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("SubRegion")
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("AddressCountries");
                });

            modelBuilder.Entity("ECommerce.Entities.Concrete.UserManagement.Address.AddressState", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddressCountryId")
                        .HasColumnType("int");

                    b.Property<string>("Latitude")
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Longitude")
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("StateCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.HasIndex("AddressCountryId");

                    b.ToTable("AddressStates");
                });

            modelBuilder.Entity("ECommerce.Entities.Concrete.UserManagement.UserAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AddressCityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("GsmNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AddressCityId");

                    b.HasIndex("UserId");

                    b.ToTable("UserAddresses");
                });

            modelBuilder.Entity("ECommerce.Entities.Concrete.UserManagement.UserCreditCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("AccountNumberHash")
                        .IsRequired()
                        .HasColumnType("varbinary(1000)");

                    b.Property<byte[]>("AccountNumberSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(1000)");

                    b.Property<string>("CardHolderName")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<byte[]>("CvcHash")
                        .IsRequired()
                        .HasColumnType("varbinary(1000)");

                    b.Property<byte[]>("CvcSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(1000)");

                    b.Property<int>("ExpireMonth")
                        .HasColumnType("int");

                    b.Property<int>("ExpireYear")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserCreditCards");
                });

            modelBuilder.Entity("ECommerce.Core.Entities.Concrete.UserOperationClaim", b =>
                {
                    b.HasOne("ECommerce.Core.Entities.Concrete.OperationClaim", "OperationClaim")
                        .WithMany()
                        .HasForeignKey("OperationClaimId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ECommerce.Core.Entities.Concrete.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("OperationClaim");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ECommerce.Entities.Concrete.OrderManagement.CartItem", b =>
                {
                    b.HasOne("ECommerce.Entities.Concrete.ProductManagement.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ECommerce.Entities.Concrete.OrderManagement.ShoppingSession", "ShoppingSession")
                        .WithMany()
                        .HasForeignKey("ShoppingSessionId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("ShoppingSession");
                });

            modelBuilder.Entity("ECommerce.Entities.Concrete.OrderManagement.OrderDetail", b =>
                {
                    b.HasOne("ECommerce.Entities.Concrete.OrderManagement.PaymentDetail", "PaymentDetail")
                        .WithOne()
                        .HasForeignKey("ECommerce.Entities.Concrete.OrderManagement.OrderDetail", "PaymentDetailId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ECommerce.Core.Entities.Concrete.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("PaymentDetail");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ECommerce.Entities.Concrete.OrderManagement.OrderItem", b =>
                {
                    b.HasOne("ECommerce.Entities.Concrete.OrderManagement.OrderDetail", "OrderDetail")
                        .WithMany()
                        .HasForeignKey("OrderDetailId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ECommerce.Entities.Concrete.OrderManagement.OrderItemStatus", "OrderItemStatus")
                        .WithMany()
                        .HasForeignKey("OrderItemStatusId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ECommerce.Entities.Concrete.ProductManagement.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("OrderDetail");

                    b.Navigation("OrderItemStatus");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ECommerce.Entities.Concrete.OrderManagement.ShoppingSession", b =>
                {
                    b.HasOne("ECommerce.Core.Entities.Concrete.User", "User")
                        .WithOne()
                        .HasForeignKey("ECommerce.Entities.Concrete.OrderManagement.ShoppingSession", "UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ECommerce.Entities.Concrete.ProductManagement.Product", b =>
                {
                    b.HasOne("ECommerce.Entities.Concrete.ProductManagement.ProductCategory", "ProductCategory")
                        .WithMany()
                        .HasForeignKey("ProductCategoryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ECommerce.Entities.Concrete.ProductManagement.ProductDiscount", "ProductDiscount")
                        .WithMany()
                        .HasForeignKey("ProductDiscountId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("ECommerce.Entities.Concrete.ProductManagement.ProductInventory", "ProductInventory")
                        .WithOne()
                        .HasForeignKey("ECommerce.Entities.Concrete.ProductManagement.Product", "ProductInventoryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("ProductCategory");

                    b.Navigation("ProductDiscount");

                    b.Navigation("ProductInventory");
                });

            modelBuilder.Entity("ECommerce.Entities.Concrete.ProductManagement.ProductImage", b =>
                {
                    b.HasOne("ECommerce.Entities.Concrete.ProductManagement.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ECommerce.Entities.Concrete.UserManagement.Address.AddressCity", b =>
                {
                    b.HasOne("ECommerce.Entities.Concrete.UserManagement.Address.AddressState", "AddressState")
                        .WithMany()
                        .HasForeignKey("AddressStateId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("AddressState");
                });

            modelBuilder.Entity("ECommerce.Entities.Concrete.UserManagement.Address.AddressState", b =>
                {
                    b.HasOne("ECommerce.Entities.Concrete.UserManagement.Address.AddressCountry", "AddressCountry")
                        .WithMany()
                        .HasForeignKey("AddressCountryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("AddressCountry");
                });

            modelBuilder.Entity("ECommerce.Entities.Concrete.UserManagement.UserAddress", b =>
                {
                    b.HasOne("ECommerce.Entities.Concrete.UserManagement.Address.AddressCity", "AddressCity")
                        .WithMany()
                        .HasForeignKey("AddressCityId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ECommerce.Core.Entities.Concrete.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("AddressCity");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ECommerce.Entities.Concrete.UserManagement.UserCreditCard", b =>
                {
                    b.HasOne("ECommerce.Core.Entities.Concrete.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}