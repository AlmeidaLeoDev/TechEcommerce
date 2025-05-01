using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TechEcommerce.Migrations
{
    /// <inheritdoc />
    public partial class PopulateDatabaseWithSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "stock",
                table: "Products",
                newName: "Stock");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { 1, "Input and output devices", "Peripherals" },
                    { 2, "Internal hardware parts", "Components" },
                    { 3, "Headphones, speakers, and headsets", "Audio" }
                });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Id", "CategoryId", "Description", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Mechanical and membrane", "Keyboards" },
                    { 2, 1, "Gaming and office", "Mice" },
                    { 3, 1, "LED, IPS, and curved displays", "Monitors" },
                    { 4, 2, "GPUs for gaming and creation", "Graphics Cards" },
                    { 5, 2, "DDR4 and DDR5 modules", "RAM" },
                    { 6, 2, "NVMe and SATA drives", "SSDs" },
                    { 7, 3, "Wired and wireless", "Headsets" },
                    { 8, 3, "Bluetooth and 2.1 systems", "Speakers" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name", "Price", "Stock", "SubcategoryId" },
                values: new object[,]
                {
                    { 1, 1, "Outemu switches, full RGB lighting.", "/images/product/keyboards/RgbMechanicalKeyboard.png", "RGB Mechanical Keyboard", 249.90m, 50, 1 },
                    { 2, 1, "Hot-swappable switches, low profile.", "/images/product/keyboards/60CompactKeyboard.png", "60% Compact Keyboard", 299.50m, 30, 1 },
                    { 3, 1, "Advanced optical sensor, 7 programmable buttons.", "/images/product/mice/16000DPIGamingMouse.png", "16000 DPI Gaming Mouse", 159.90m, 75, 2 },
                    { 4, 1, "Ergonomic, plug & play connection.", "/images/product/mice/USBOpticalMouse.png", "USB Optical Mouse", 49.90m, 120, 2 },
                    { 5, 1, "Full HD, 1ms response time.", "/images/product/monitors/144HzGamingMonitor.png", "27\" 144Hz Gaming Monitor", 1299.00m, 20, 3 },
                    { 6, 1, "Accurate colors and wide viewing angles.", "/images/product/monitors/IPSMonitor.png", "24\" IPS Monitor", 899.90m, 35, 3 },
                    { 7, 2, "12GB GDDR6X, real-time ray tracing.", "/images/product/graphicsCards/RTX4070Ti.png", "RTX 4070 Ti", 3499.00m, 10, 4 },
                    { 8, 2, "16GB GDDR6, great 1440p performance.", "/images/product/graphicsCards/RX6800XT.png", "RX 6800 XT", 2999.00m, 8, 4 },
                    { 9, 2, "2×8GB kit, CL16 latency.", "/images/product/ram/16GBDDR43200MHz.png", "16GB DDR4 3200MHz", 399.90m, 60, 5 },
                    { 10, 2, "2×16GB kit, extreme performance.", "/images/product/ram/32GBDDR55600MHz.png", "32GB DDR5 5600MHz", 999.90m, 40, 5 },
                    { 11, 2, "3500MB/s read, 3000MB/s write.", "/images/product/ssds/1TBNVMeSSD.png", "1TB NVMe SSD", 549.90m, 50, 6 },
                    { 12, 2, "550MB/s read, 500MB/s write.", "/images/product/ssds/500GBSATASSD.png", "500GB SATA SSD", 249.90m, 80, 6 },
                    { 13, 3, "Virtual 7.1 surround, detachable mic.", "/images/product/headsets/71GamingHeadset.png", "7.1 Gaming Headset", 219.90m, 45, 7 },
                    { 14, 3, "Bluetooth 5.0, 20h battery life.", "/images/product/headsets/WirelessHeadset.png", "Wireless Headset", 299.90m, 35, 7 },
                    { 15, 3, "Stereo sound, 8h battery life.", "/images/product/speakers/10WBluetoothSpeaker.png", "10W Bluetooth Speaker", 149.90m, 70, 8 },
                    { 16, 3, "Wireless subwoofer, remote control.", "/images/product/speakers/21Soundbar.png", "2.1 Soundbar", 499.90m, 25, 8 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Subcategories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.RenameColumn(
                name: "Stock",
                table: "Products",
                newName: "stock");
        }
    }
}
