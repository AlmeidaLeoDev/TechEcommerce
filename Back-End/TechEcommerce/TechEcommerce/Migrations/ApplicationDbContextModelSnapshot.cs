﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TechEcommerce.Context;

#nullable disable

namespace TechEcommerce.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("TechEcommerce.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Input and output devices",
                            Title = "Peripherals"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Internal hardware parts",
                            Title = "Components"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Headphones, speakers, and headsets",
                            Title = "Audio"
                        });
                });

            modelBuilder.Entity("TechEcommerce.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Status")
                        .HasColumnType("longtext");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("TechEcommerce.Models.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("TechEcommerce.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<int>("SubcategoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SubcategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Outemu switches, full RGB lighting.",
                            ImageUrl = "/images/product/keyboards/RgbMechanicalKeyboard.png",
                            Name = "RGB Mechanical Keyboard",
                            Price = 249.90m,
                            Stock = 50,
                            SubcategoryId = 1
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Hot-swappable switches, low profile.",
                            ImageUrl = "/images/product/keyboards/60CompactKeyboard.png",
                            Name = "60% Compact Keyboard",
                            Price = 299.50m,
                            Stock = 30,
                            SubcategoryId = 1
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "Advanced optical sensor, 7 programmable buttons.",
                            ImageUrl = "/images/product/mice/16000DPIGamingMouse.png",
                            Name = "16000 DPI Gaming Mouse",
                            Price = 159.90m,
                            Stock = 75,
                            SubcategoryId = 2
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Description = "Ergonomic, plug & play connection.",
                            ImageUrl = "/images/product/mice/USBOpticalMouse.png",
                            Name = "USB Optical Mouse",
                            Price = 49.90m,
                            Stock = 120,
                            SubcategoryId = 2
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Description = "Full HD, 1ms response time.",
                            ImageUrl = "/images/product/monitors/144HzGamingMonitor.png",
                            Name = "27\" 144Hz Gaming Monitor",
                            Price = 1299.00m,
                            Stock = 20,
                            SubcategoryId = 3
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 1,
                            Description = "Accurate colors and wide viewing angles.",
                            ImageUrl = "/images/product/monitors/IPSMonitor.png",
                            Name = "24\" IPS Monitor",
                            Price = 899.90m,
                            Stock = 35,
                            SubcategoryId = 3
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 2,
                            Description = "12GB GDDR6X, real-time ray tracing.",
                            ImageUrl = "/images/product/graphicsCards/RTX4070Ti.png",
                            Name = "RTX 4070 Ti",
                            Price = 3499.00m,
                            Stock = 10,
                            SubcategoryId = 4
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 2,
                            Description = "16GB GDDR6, great 1440p performance.",
                            ImageUrl = "/images/product/graphicsCards/RX6800XT.png",
                            Name = "RX 6800 XT",
                            Price = 2999.00m,
                            Stock = 8,
                            SubcategoryId = 4
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 2,
                            Description = "2×8GB kit, CL16 latency.",
                            ImageUrl = "/images/product/ram/16GBDDR43200MHz.png",
                            Name = "16GB DDR4 3200MHz",
                            Price = 399.90m,
                            Stock = 60,
                            SubcategoryId = 5
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 2,
                            Description = "2×16GB kit, extreme performance.",
                            ImageUrl = "/images/product/ram/32GBDDR55600MHz.png",
                            Name = "32GB DDR5 5600MHz",
                            Price = 999.90m,
                            Stock = 40,
                            SubcategoryId = 5
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 2,
                            Description = "3500MB/s read, 3000MB/s write.",
                            ImageUrl = "/images/product/ssds/1TBNVMeSSD.png",
                            Name = "1TB NVMe SSD",
                            Price = 549.90m,
                            Stock = 50,
                            SubcategoryId = 6
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 2,
                            Description = "550MB/s read, 500MB/s write.",
                            ImageUrl = "/images/product/ssds/500GBSATASSD.png",
                            Name = "500GB SATA SSD",
                            Price = 249.90m,
                            Stock = 80,
                            SubcategoryId = 6
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 3,
                            Description = "Virtual 7.1 surround, detachable mic.",
                            ImageUrl = "/images/product/headsets/71GamingHeadset.png",
                            Name = "7.1 Gaming Headset",
                            Price = 219.90m,
                            Stock = 45,
                            SubcategoryId = 7
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 3,
                            Description = "Bluetooth 5.0, 20h battery life.",
                            ImageUrl = "/images/product/headsets/WirelessHeadset.png",
                            Name = "Wireless Headset",
                            Price = 299.90m,
                            Stock = 35,
                            SubcategoryId = 7
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 3,
                            Description = "Stereo sound, 8h battery life.",
                            ImageUrl = "/images/product/speakers/10WBluetoothSpeaker.png",
                            Name = "10W Bluetooth Speaker",
                            Price = 149.90m,
                            Stock = 70,
                            SubcategoryId = 8
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 3,
                            Description = "Wireless subwoofer, remote control.",
                            ImageUrl = "/images/product/speakers/21Soundbar.png",
                            Name = "2.1 Soundbar",
                            Price = 499.90m,
                            Stock = 25,
                            SubcategoryId = 8
                        });
                });

            modelBuilder.Entity("TechEcommerce.Models.ShoppingCart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("shoppingCarts");
                });

            modelBuilder.Entity("TechEcommerce.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("Productid")
                        .HasColumnType("int");

                    b.Property<int>("ShoppingCartId")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("Productid");

                    b.HasIndex("ShoppingCartId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("TechEcommerce.Models.Subcategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Subcategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Mechanical and membrane",
                            Title = "Keyboards"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Gaming and office",
                            Title = "Mice"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "LED, IPS, and curved displays",
                            Title = "Monitors"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Description = "GPUs for gaming and creation",
                            Title = "Graphics Cards"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Description = "DDR4 and DDR5 modules",
                            Title = "RAM"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Description = "NVMe and SATA drives",
                            Title = "SSDs"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            Description = "Wired and wireless",
                            Title = "Headsets"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            Description = "Bluetooth and 2.1 systems",
                            Title = "Speakers"
                        });
                });

            modelBuilder.Entity("TechEcommerce.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("HashPassword")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TechEcommerce.Models.Order", b =>
                {
                    b.HasOne("TechEcommerce.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TechEcommerce.Models.OrderItem", b =>
                {
                    b.HasOne("TechEcommerce.Models.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TechEcommerce.Models.Product", "Product")
                        .WithMany("OrderItems")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("TechEcommerce.Models.Product", b =>
                {
                    b.HasOne("TechEcommerce.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TechEcommerce.Models.Subcategory", "Subcategory")
                        .WithMany("Products")
                        .HasForeignKey("SubcategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Subcategory");
                });

            modelBuilder.Entity("TechEcommerce.Models.ShoppingCart", b =>
                {
                    b.HasOne("TechEcommerce.Models.User", "User")
                        .WithMany("ShoppingCarts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TechEcommerce.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("TechEcommerce.Models.Product", "Product")
                        .WithMany("ShoppingCartItems")
                        .HasForeignKey("Productid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TechEcommerce.Models.ShoppingCart", "ShoppingCart")
                        .WithMany("ShoppingCartItems")
                        .HasForeignKey("ShoppingCartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("ShoppingCart");
                });

            modelBuilder.Entity("TechEcommerce.Models.Subcategory", b =>
                {
                    b.HasOne("TechEcommerce.Models.Category", "Category")
                        .WithMany("Subcategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("TechEcommerce.Models.Category", b =>
                {
                    b.Navigation("Products");

                    b.Navigation("Subcategories");
                });

            modelBuilder.Entity("TechEcommerce.Models.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("TechEcommerce.Models.Product", b =>
                {
                    b.Navigation("OrderItems");

                    b.Navigation("ShoppingCartItems");
                });

            modelBuilder.Entity("TechEcommerce.Models.ShoppingCart", b =>
                {
                    b.Navigation("ShoppingCartItems");
                });

            modelBuilder.Entity("TechEcommerce.Models.Subcategory", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("TechEcommerce.Models.User", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("ShoppingCarts");
                });
#pragma warning restore 612, 618
        }
    }
}
