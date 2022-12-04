﻿// <auto-generated />
using System;
using DataAccess.Concrete.EntityFramework.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(EticaretContext))]
    partial class EticaretContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Concrete.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AddressDetail")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("AddressDetail");

                    b.Property<Guid>("CityId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CityId");

                    b.Property<Guid>("CountryId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CountryId");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CustomerId");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PostalCode");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("CountryId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Entities.Concrete.Basket", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CustomerId");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Baskets");
                });

            modelBuilder.Entity("Entities.Concrete.BasketDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Amount")
                        .HasColumnType("real")
                        .HasColumnName("Amount");

                    b.Property<Guid>("BasketId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("BasketId");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<float>("Price")
                        .HasColumnType("real")
                        .HasColumnName("Price");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ProductId");

                    b.Property<float>("Total")
                        .HasColumnType("real")
                        .HasColumnName("Total");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BasketId");

                    b.HasIndex("ProductId");

                    b.ToTable("BasketDetail");
                });

            modelBuilder.Entity("Entities.Concrete.Brand", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Name");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("Entities.Concrete.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Name");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Entities.Concrete.City", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CountryId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CountryId");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("Name");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Entities.Concrete.Color", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("Entities.Concrete.Country", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Entities.Concrete.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerType")
                        .HasColumnType("int")
                        .HasColumnName("CustomerType");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Entities.Concrete.Individual", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CustomerId");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2")
                        .HasColumnName("DateOfBirth");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("FirstName");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("LastName");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Individual");
                });

            modelBuilder.Entity("Entities.Concrete.Menu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<int>("DisplayOrder")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0)
                        .HasColumnName("DisplayOrder");

                    b.Property<bool>("Hidden")
                        .HasColumnType("bit")
                        .HasColumnName("Hidden");

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Icon");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("Name");

                    b.Property<Guid?>("ParentMenuId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Url");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("ParentMenuId");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("Entities.Concrete.OperationClaim", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("OperationClaims");
                });

            modelBuilder.Entity("Entities.Concrete.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AddressId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("AddressId");

                    b.Property<int>("Amount")
                        .HasColumnType("int")
                        .HasColumnName("Amount");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CustomerId");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<int>("OrderStatus")
                        .HasColumnType("int")
                        .HasColumnName("OrderStatus");

                    b.Property<Guid>("ShipperId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ShipperId");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ShipperId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Entities.Concrete.OrderDetail", b =>
                {
                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Amount")
                        .HasColumnType("int")
                        .HasColumnName("Amount");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SalePrice")
                        .HasColumnType("int")
                        .HasColumnName("SalePrice");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("OrderId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("Entities.Concrete.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BrandId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("BrandId");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CategoryId");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("Code");

                    b.Property<Guid>("ColorId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ColorId");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Name");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("UnitPrice");

                    b.Property<short>("UnitsInStock")
                        .HasColumnType("smallint")
                        .HasColumnName("UnitsInStock");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.HasIndex("ColorId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Entities.Concrete.Shipper", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Shipper");
                });

            modelBuilder.Entity("Entities.Concrete.Supplier", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("CompanyName");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CustomerId");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Fax")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Fax");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Website");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("Entities.Concrete.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("FirstName");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("IsActive");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("LastName");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("PasswordHash");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)")
                        .HasColumnName("PasswordSalt");

                    b.Property<string>("Phone")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("Phone");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Entities.Concrete.UserOperationClaim", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("OperationClaimId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("OperationClaimId");

                    b.HasIndex("UserId");

                    b.ToTable("UserOperationClaims");
                });

            modelBuilder.Entity("Entities.Concrete.Address", b =>
                {
                    b.HasOne("Entities.Concrete.City", "City")
                        .WithMany("Addresses")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Country", "Country")
                        .WithMany("Addresses")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Customer", "Customer")
                        .WithMany("Addresses")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("Country");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Entities.Concrete.Basket", b =>
                {
                    b.HasOne("Entities.Concrete.Customer", "Customer")
                        .WithMany("Baskets")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Entities.Concrete.BasketDetail", b =>
                {
                    b.HasOne("Entities.Concrete.Basket", "Basket")
                        .WithMany("BasketDetails")
                        .HasForeignKey("BasketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Product", "Product")
                        .WithMany("BasketDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Basket");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Entities.Concrete.City", b =>
                {
                    b.HasOne("Entities.Concrete.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Entities.Concrete.Customer", b =>
                {
                    b.HasOne("Entities.Concrete.User", "User")
                        .WithMany("Customers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Concrete.Individual", b =>
                {
                    b.HasOne("Entities.Concrete.Customer", "Customer")
                        .WithMany("Individuals")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Entities.Concrete.Menu", b =>
                {
                    b.HasOne("Entities.Concrete.Menu", "ParentMenu")
                        .WithMany("Childeren")
                        .HasForeignKey("ParentMenuId");

                    b.Navigation("ParentMenu");
                });

            modelBuilder.Entity("Entities.Concrete.Order", b =>
                {
                    b.HasOne("Entities.Concrete.Address", "Address")
                        .WithMany("Orders")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Shipper", "Shipper")
                        .WithMany("Orders")
                        .HasForeignKey("ShipperId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Customer");

                    b.Navigation("Shipper");
                });

            modelBuilder.Entity("Entities.Concrete.OrderDetail", b =>
                {
                    b.HasOne("Entities.Concrete.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Entities.Concrete.Product", b =>
                {
                    b.HasOne("Entities.Concrete.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Color", "Color")
                        .WithMany("Products")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Category");

                    b.Navigation("Color");
                });

            modelBuilder.Entity("Entities.Concrete.Supplier", b =>
                {
                    b.HasOne("Entities.Concrete.Customer", "Customer")
                        .WithMany("Suppliers")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Entities.Concrete.UserOperationClaim", b =>
                {
                    b.HasOne("Entities.Concrete.OperationClaim", "OperationClaim")
                        .WithMany("UserOperationClaims")
                        .HasForeignKey("OperationClaimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.User", "User")
                        .WithMany("UserOperationClaims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OperationClaim");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Concrete.Address", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Entities.Concrete.Basket", b =>
                {
                    b.Navigation("BasketDetails");
                });

            modelBuilder.Entity("Entities.Concrete.Brand", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Entities.Concrete.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Entities.Concrete.City", b =>
                {
                    b.Navigation("Addresses");
                });

            modelBuilder.Entity("Entities.Concrete.Color", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Entities.Concrete.Country", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("Cities");
                });

            modelBuilder.Entity("Entities.Concrete.Customer", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("Baskets");

                    b.Navigation("Individuals");

                    b.Navigation("Orders");

                    b.Navigation("Suppliers");
                });

            modelBuilder.Entity("Entities.Concrete.Menu", b =>
                {
                    b.Navigation("Childeren");
                });

            modelBuilder.Entity("Entities.Concrete.OperationClaim", b =>
                {
                    b.Navigation("UserOperationClaims");
                });

            modelBuilder.Entity("Entities.Concrete.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("Entities.Concrete.Product", b =>
                {
                    b.Navigation("BasketDetails");

                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("Entities.Concrete.Shipper", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Entities.Concrete.User", b =>
                {
                    b.Navigation("Customers");

                    b.Navigation("UserOperationClaims");
                });
#pragma warning restore 612, 618
        }
    }
}
