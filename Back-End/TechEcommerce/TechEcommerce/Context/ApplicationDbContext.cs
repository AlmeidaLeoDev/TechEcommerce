using Microsoft.EntityFrameworkCore;
using TechEcommerce.Models;

namespace TechEcommerce.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Subcategory> Subcategories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<ShoppingCart> shoppingCarts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // 1) Categories
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Title = "Peripherals", Description = "Input and output devices" },
                new Category { Id = 2, Title = "Components", Description = "Internal hardware parts" },
                new Category { Id = 3, Title = "Audio", Description = "Headphones, speakers, and headsets" }
            );

            // 2) Subcategories
            modelBuilder.Entity<Subcategory>().HasData(
                // Peripherals
                new Subcategory { Id = 1, Title = "Keyboards", Description = "Mechanical and membrane", CategoryId = 1 },
                new Subcategory { Id = 2, Title = "Mice", Description = "Gaming and office", CategoryId = 1 },
                new Subcategory { Id = 3, Title = "Monitors", Description = "LED, IPS, and curved displays", CategoryId = 1 },

                // Components
                new Subcategory { Id = 4, Title = "Graphics Cards", Description = "GPUs for gaming and creation", CategoryId = 2 },
                new Subcategory { Id = 5, Title = "RAM", Description = "DDR4 and DDR5 modules", CategoryId = 2 },
                new Subcategory { Id = 6, Title = "SSDs", Description = "NVMe and SATA drives", CategoryId = 2 },

                // Audio
                new Subcategory { Id = 7, Title = "Headsets", Description = "Wired and wireless", CategoryId = 3 },
                new Subcategory { Id = 8, Title = "Speakers", Description = "Bluetooth and 2.1 systems", CategoryId = 3 }
            );

            // 3) Products
            modelBuilder.Entity<Product>().HasData(
                // Keyboards
                new Product
                {
                    Id = 1,
                    Name = "RGB Mechanical Keyboard",
                    Description = "Outemu switches, full RGB lighting.",
                    Price = 249.90m,
                    Stock = 50,
                    ImageUrl = "/images/product/keyboards/RgbMechanicalKeyboard.png",
                    CategoryId = 1,
                    SubcategoryId = 1
                },
                new Product
                {
                    Id = 2,
                    Name = "60% Compact Keyboard",
                    Description = "Hot-swappable switches, low profile.",
                    Price = 299.50m,
                    Stock = 30,
                    ImageUrl = "/images/product/keyboards/60CompactKeyboard.png",
                    CategoryId = 1,
                    SubcategoryId = 1
                },

                // Mice
                new Product
                {
                    Id = 3,
                    Name = "16000 DPI Gaming Mouse",
                    Description = "Advanced optical sensor, 7 programmable buttons.",
                    Price = 159.90m,
                    Stock = 75,
                    ImageUrl = "/images/product/mice/16000DPIGamingMouse.png",
                    CategoryId = 1,
                    SubcategoryId = 2
                },
                new Product
                {
                    Id = 4,
                    Name = "USB Optical Mouse",
                    Description = "Ergonomic, plug & play connection.",
                    Price = 49.90m,
                    Stock = 120,
                    ImageUrl = "/images/product/mice/USBOpticalMouse.png",
                    CategoryId = 1,
                    SubcategoryId = 2
                },

                // Monitors
                new Product
                {
                    Id = 5,
                    Name = "27\" 144Hz Gaming Monitor",
                    Description = "Full HD, 1ms response time.",
                    Price = 1299.00m,
                    Stock = 20,
                    ImageUrl = "/images/product/monitors/144HzGamingMonitor.png",
                    CategoryId = 1,
                    SubcategoryId = 3
                },
                new Product
                {
                    Id = 6,
                    Name = "24\" IPS Monitor",
                    Description = "Accurate colors and wide viewing angles.",
                    Price = 899.90m,
                    Stock = 35,
                    ImageUrl = "/images/product/monitors/IPSMonitor.png",
                    CategoryId = 1,
                    SubcategoryId = 3
                },

                // Graphics Cards
                new Product
                {
                    Id = 7,
                    Name = "RTX 4070 Ti",
                    Description = "12GB GDDR6X, real-time ray tracing.",
                    Price = 3499.00m,
                    Stock = 10,
                    ImageUrl = "/images/product/graphicsCards/RTX4070Ti.png",
                    CategoryId = 2,
                    SubcategoryId = 4
                },
                new Product
                {
                    Id = 8,
                    Name = "RX 6800 XT",
                    Description = "16GB GDDR6, great 1440p performance.",
                    Price = 2999.00m,
                    Stock = 8,
                    ImageUrl = "/images/product/graphicsCards/RX6800XT.png",
                    CategoryId = 2,
                    SubcategoryId = 4
                },

                // RAM
                new Product
                {
                    Id = 9,
                    Name = "16GB DDR4 3200MHz",
                    Description = "2×8GB kit, CL16 latency.",
                    Price = 399.90m,
                    Stock = 60,
                    ImageUrl = "/images/product/ram/16GBDDR43200MHz.png",
                    CategoryId = 2,
                    SubcategoryId = 5
                },
                new Product
                {
                    Id = 10,
                    Name = "32GB DDR5 5600MHz",
                    Description = "2×16GB kit, extreme performance.",
                    Price = 999.90m,
                    Stock = 40,
                    ImageUrl = "/images/product/ram/32GBDDR55600MHz.png",
                    CategoryId = 2,
                    SubcategoryId = 5
                },

                // SSDs
                new Product
                {
                    Id = 11,
                    Name = "1TB NVMe SSD",
                    Description = "3500MB/s read, 3000MB/s write.",
                    Price = 549.90m,
                    Stock = 50,
                    ImageUrl = "/images/product/ssds/1TBNVMeSSD.png",
                    CategoryId = 2,
                    SubcategoryId = 6
                },
                new Product
                {
                    Id = 12,
                    Name = "500GB SATA SSD",
                    Description = "550MB/s read, 500MB/s write.",
                    Price = 249.90m,
                    Stock = 80,
                    ImageUrl = "/images/product/ssds/500GBSATASSD.png",
                    CategoryId = 2,
                    SubcategoryId = 6
                },

                // Headsets
                new Product
                {
                    Id = 13,
                    Name = "7.1 Gaming Headset",
                    Description = "Virtual 7.1 surround, detachable mic.",
                    Price = 219.90m,
                    Stock = 45,
                    ImageUrl = "/images/product/headsets/71GamingHeadset.png",
                    CategoryId = 3,
                    SubcategoryId = 7
                },
                new Product
                {
                    Id = 14,
                    Name = "Wireless Headset",
                    Description = "Bluetooth 5.0, 20h battery life.",
                    Price = 299.90m,
                    Stock = 35,
                    ImageUrl = "/images/product/headsets/WirelessHeadset.png",
                    CategoryId = 3,
                    SubcategoryId = 7
                },

                // Speakers
                new Product
                {
                    Id = 15,
                    Name = "10W Bluetooth Speaker",
                    Description = "Stereo sound, 8h battery life.",
                    Price = 149.90m,
                    Stock = 70,
                    ImageUrl = "/images/product/speakers/10WBluetoothSpeaker.png",
                    CategoryId = 3,
                    SubcategoryId = 8
                },
                new Product
                {
                    Id = 16,
                    Name = "2.1 Soundbar",
                    Description = "Wireless subwoofer, remote control.",
                    Price = 499.90m,
                    Stock = 25,
                    ImageUrl = "/images/product/speakers/21Soundbar.png",
                    CategoryId = 3,
                    SubcategoryId = 8
                }
            );
        }
    }
}
