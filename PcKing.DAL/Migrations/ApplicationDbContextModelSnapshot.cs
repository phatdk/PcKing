﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PcKing.DAL.DbApplication;

#nullable disable

namespace PcKing.DAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PcKing.DAL.Entity.Brand", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Index")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("PcKing.DAL.Entity.Cart", b =>
                {
                    b.Property<Guid>("Id_User")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id_User");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("PcKing.DAL.Entity.CartDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Id_Product")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Id_User")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id_Product");

                    b.HasIndex("Id_User");

                    b.ToTable("CartDetails");
                });

            modelBuilder.Entity("PcKing.DAL.Entity.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Index")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("PcKing.DAL.Entity.Comment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Id_Product")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Id_User")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id_Product");

                    b.HasIndex("Id_User");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("PcKing.DAL.Entity.CustomAttribute", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AttributeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("DataType")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("CustomAttributes");
                });

            modelBuilder.Entity("PcKing.DAL.Entity.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Id_Product")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImgUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id_Product");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("PcKing.DAL.Entity.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("AcceptDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(255)");

                    b.Property<Guid>("Id_Status")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Id_User")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifyDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifyNote")
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime?>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Phones")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime?>("ReciveDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Reciver")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("ShipFee")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.HasIndex("Id_Status");

                    b.HasIndex("Id_User");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("PcKing.DAL.Entity.OrderDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Id_Order")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Id_Product")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id_Order");

                    b.HasIndex("Id_Product");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("PcKing.DAL.Entity.Payment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("PcKing.DAL.Entity.PaymentOrder", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Id_Order")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Id_Payment")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("PaymentAmount")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id_Order");

                    b.HasIndex("Id_Payment");

                    b.ToTable("PaymentOrders");
                });

            modelBuilder.Entity("PcKing.DAL.Entity.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(255)");

                    b.Property<Guid?>("Id_Brand")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Id_Category")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ImportPrice")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id_Brand");

                    b.HasIndex("Id_Category");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("PcKing.DAL.Entity.ReturnOrder", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Id_Order")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Id_OrderDetail")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id_Order");

                    b.HasIndex("Id_OrderDetail");

                    b.ToTable("ReturnOrders");
                });

            modelBuilder.Entity("PcKing.DAL.Entity.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("PcKing.DAL.Entity.StatusOrder", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("StatusName")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("StatusOrders");
                });

            modelBuilder.Entity("PcKing.DAL.Entity.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("Birth")
                        .HasColumnType("date");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<Guid>("Id_Role")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Img")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Phones")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Id_Role");

                    b.HasIndex("Phones")
                        .IsUnique();

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PcKing.DAL.Entity.Value", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AttributeValue")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<Guid>("Id_Attribute")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Id_Product")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("Id_Attribute");

                    b.HasIndex("Id_Product");

                    b.ToTable("Values");
                });

            modelBuilder.Entity("PcKing.DAL.Entity.Cart", b =>
                {
                    b.HasOne("PcKing.DAL.Entity.User", "User")
                        .WithOne("Cart")
                        .HasForeignKey("PcKing.DAL.Entity.Cart", "Id_User")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("PcKing.DAL.Entity.CartDetail", b =>
                {
                    b.HasOne("PcKing.DAL.Entity.Product", "Product")
                        .WithMany("CartDetails")
                        .HasForeignKey("Id_Product")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("PcKing.DAL.Entity.Cart", "Cart")
                        .WithMany("CartDetails")
                        .HasForeignKey("Id_User")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("PcKing.DAL.Entity.Comment", b =>
                {
                    b.HasOne("PcKing.DAL.Entity.OrderDetail", "OrderDetail")
                        .WithMany("Comments")
                        .HasForeignKey("Id_Product")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("PcKing.DAL.Entity.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("Id_User")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("OrderDetail");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PcKing.DAL.Entity.Image", b =>
                {
                    b.HasOne("PcKing.DAL.Entity.Product", "Product")
                        .WithMany("Images")
                        .HasForeignKey("Id_Product")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("PcKing.DAL.Entity.Order", b =>
                {
                    b.HasOne("PcKing.DAL.Entity.StatusOrder", "StatusOrder")
                        .WithMany("Orders")
                        .HasForeignKey("Id_Status")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("PcKing.DAL.Entity.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("Id_User")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("StatusOrder");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PcKing.DAL.Entity.OrderDetail", b =>
                {
                    b.HasOne("PcKing.DAL.Entity.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("Id_Order")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("PcKing.DAL.Entity.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("Id_Product")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("PcKing.DAL.Entity.PaymentOrder", b =>
                {
                    b.HasOne("PcKing.DAL.Entity.Order", "Order")
                        .WithMany("PaymentOrders")
                        .HasForeignKey("Id_Order")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PcKing.DAL.Entity.Payment", "Payment")
                        .WithMany("PaymentOrders")
                        .HasForeignKey("Id_Payment")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Payment");
                });

            modelBuilder.Entity("PcKing.DAL.Entity.Product", b =>
                {
                    b.HasOne("PcKing.DAL.Entity.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("Id_Brand")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("PcKing.DAL.Entity.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("Id_Category")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("PcKing.DAL.Entity.ReturnOrder", b =>
                {
                    b.HasOne("PcKing.DAL.Entity.Order", "Order")
                        .WithMany("ReturnOrders")
                        .HasForeignKey("Id_Order")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PcKing.DAL.Entity.OrderDetail", "OrderDetail")
                        .WithMany("ReturnOrders")
                        .HasForeignKey("Id_OrderDetail")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("OrderDetail");
                });

            modelBuilder.Entity("PcKing.DAL.Entity.User", b =>
                {
                    b.HasOne("PcKing.DAL.Entity.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("Id_Role")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("PcKing.DAL.Entity.Value", b =>
                {
                    b.HasOne("PcKing.DAL.Entity.CustomAttribute", "Attribute")
                        .WithMany("Values")
                        .HasForeignKey("Id_Attribute")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PcKing.DAL.Entity.Product", "Product")
                        .WithMany("Values")
                        .HasForeignKey("Id_Product")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Attribute");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("PcKing.DAL.Entity.Brand", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("PcKing.DAL.Entity.Cart", b =>
                {
                    b.Navigation("CartDetails");
                });

            modelBuilder.Entity("PcKing.DAL.Entity.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("PcKing.DAL.Entity.CustomAttribute", b =>
                {
                    b.Navigation("Values");
                });

            modelBuilder.Entity("PcKing.DAL.Entity.Order", b =>
                {
                    b.Navigation("OrderDetails");

                    b.Navigation("PaymentOrders");

                    b.Navigation("ReturnOrders");
                });

            modelBuilder.Entity("PcKing.DAL.Entity.OrderDetail", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("ReturnOrders");
                });

            modelBuilder.Entity("PcKing.DAL.Entity.Payment", b =>
                {
                    b.Navigation("PaymentOrders");
                });

            modelBuilder.Entity("PcKing.DAL.Entity.Product", b =>
                {
                    b.Navigation("CartDetails");

                    b.Navigation("Images");

                    b.Navigation("OrderDetails");

                    b.Navigation("Values");
                });

            modelBuilder.Entity("PcKing.DAL.Entity.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("PcKing.DAL.Entity.StatusOrder", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("PcKing.DAL.Entity.User", b =>
                {
                    b.Navigation("Cart")
                        .IsRequired();

                    b.Navigation("Comments");

                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
