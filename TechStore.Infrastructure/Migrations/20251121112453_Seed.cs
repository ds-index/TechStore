using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TechStore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryDescription", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Mobile phones and smart devices", "Smartphones" },
                    { 2, "Portable computers and notebooks", "Laptops" },
                    { 3, "Touch-based portable devices", "Tablets" },
                    { 4, "Wearable smart devices", "Smart Watches" },
                    { 5, "Audio devices and earphones", "Headphones" },
                    { 6, "Devices for gaming and entertainment", "Gaming Consoles" },
                    { 7, "Tech accessories and peripherals", "Accessories" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Inventory", "IsDeleted", "Price", "ProductDescription", "ProductName" },
                values: new object[,]
                {
                    { 1, 1, 20, false, 1199m, "Apple flagship smartphone", "iPhone 15 Pro Max" },
                    { 2, 1, 25, false, 799m, "Apple previous generation phone", "iPhone 14" },
                    { 3, 1, 18, false, 1099m, "Samsung top-tier phone", "Samsung Galaxy S24 Ultra" },
                    { 4, 1, 22, false, 799m, "High-end Samsung smartphone", "Samsung Galaxy S23" },
                    { 5, 1, 15, false, 999m, "Google AI-powered flagship", "Google Pixel 8 Pro" },
                    { 6, 1, 28, false, 599m, "Affordable flagship experience", "Google Pixel 7" },
                    { 7, 1, 30, false, 799m, "Xiaomi premium phone with Leica camera", "Xiaomi 14 Pro" },
                    { 8, 1, 40, false, 299m, "Best mid-range Xiaomi device", "Xiaomi Redmi Note 12 Pro" },
                    { 9, 1, 20, false, 699m, "High-performance flagship killer", "OnePlus 12" },
                    { 10, 1, 35, false, 329m, "Mid-range OnePlus smartphone", "OnePlus Nord CE 3" },
                    { 11, 1, 12, false, 899m, "Premium camera-focused smartphone", "Huawei P60 Pro" },
                    { 12, 1, 25, false, 399m, "Stylish mid-range smartphone", "Huawei Nova 11" },
                    { 13, 1, 10, false, 1299m, "Sony flagship with pro camera features", "Sony Xperia 1 V" },
                    { 14, 1, 14, false, 799m, "Compact premium smartphone", "Sony Xperia 5 V" },
                    { 15, 1, 18, false, 499m, "Eco-friendly smartphone", "Nokia X30" },
                    { 16, 1, 20, false, 899m, "Motorola flagship smartphone", "Motorola Edge 40 Pro" },
                    { 17, 1, 45, false, 199m, "Affordable phone with long battery", "Motorola Moto G Power 2023" },
                    { 18, 1, 12, false, 999m, "Gaming smartphone beast", "Asus ROG Phone 7" },
                    { 19, 1, 22, false, 599m, "Unique transparent design phone", "Nothing Phone 2" },
                    { 20, 1, 26, false, 549m, "Affordable flagship performance", "Realme GT 5 Pro" },
                    { 21, 2, 15, false, 1299m, "Lightweight Apple laptop", "MacBook Air M3" },
                    { 22, 2, 8, false, 3499m, "Apple high-performance laptop", "MacBook Pro 16 M3 Max" },
                    { 23, 2, 12, false, 2199m, "Apple portable powerhouse", "MacBook Pro 14 M3" },
                    { 24, 2, 10, false, 1799m, "Dell premium ultrabook", "Dell XPS 15" },
                    { 25, 2, 22, false, 599m, "Affordable laptop for students", "Dell Inspiron 14" },
                    { 26, 2, 11, false, 1599m, "Premium 2-in-1 ultrabook", "HP Spectre x360" },
                    { 27, 2, 30, false, 499m, "Budget-friendly laptop", "HP Pavilion 15" },
                    { 28, 2, 14, false, 1699m, "Business ultrabook", "Lenovo ThinkPad X1 Carbon" },
                    { 29, 2, 9, false, 2299m, "High-end gaming laptop", "Lenovo Legion 7" },
                    { 30, 2, 12, false, 1599m, "Compact gaming laptop", "ASUS ROG Zephyrus G14" },
                    { 31, 2, 18, false, 699m, "Affordable ultrabook", "ASUS VivoBook S15" },
                    { 32, 2, 20, false, 649m, "Lightweight student laptop", "Acer Swift 3" },
                    { 33, 2, 15, false, 1399m, "Mid-range gaming laptop", "Acer Predator Helios 300" },
                    { 34, 2, 10, false, 1999m, "Professional creator laptop", "MSI Stealth 16 Studio" },
                    { 35, 2, 8, false, 2499m, "Premium gaming laptop", "Razer Blade 15" },
                    { 36, 3, 14, false, 1299m, "Apple flagship tablet", "iPad Pro 12.9 M2" },
                    { 37, 3, 20, false, 599m, "Powerful lightweight tablet", "iPad Air M1" },
                    { 38, 3, 25, false, 449m, "Affordable Apple tablet", "iPad 10th Gen" },
                    { 39, 3, 18, false, 899m, "Premium Android tablet", "Samsung Galaxy Tab S9" },
                    { 40, 3, 40, false, 199m, "Budget Android tablet", "Samsung Tab A8" },
                    { 41, 3, 30, false, 399m, "Affordable power tablet", "Xiaomi Pad 6" },
                    { 42, 3, 12, false, 699m, "High-end productivity tablet", "Lenovo Tab P12 Pro" },
                    { 43, 3, 35, false, 149m, "Budget media tablet", "Amazon Fire HD 10" },
                    { 44, 3, 15, false, 599m, "Premium Huawei tablet", "Huawei MatePad 11" },
                    { 45, 3, 32, false, 229m, "Affordable entertainment tablet", "Realme Pad 2" },
                    { 46, 4, 28, false, 399m, "Top smartwatch from Apple", "Apple Watch Series 9" },
                    { 47, 4, 12, false, 799m, "Rugged smartwatch for professionals", "Apple Watch Ultra 2" },
                    { 48, 4, 26, false, 349m, "Samsung premium smartwatch", "Samsung Galaxy Watch 6" },
                    { 49, 4, 22, false, 399m, "Classic design smartwatch", "Samsung Galaxy Watch 6 Classic" },
                    { 50, 4, 35, false, 249m, "Long-lasting smartwatch", "Huawei Watch GT 4" },
                    { 51, 4, 40, false, 199m, "Stylish Xiaomi smartwatch", "Xiaomi Watch S1 Pro" },
                    { 52, 4, 45, false, 179m, "Fitness and health smartwatch", "Amazfit GTR 4" },
                    { 53, 4, 30, false, 229m, "Fitness-focused smartwatch", "Fitbit Sense 2" },
                    { 54, 4, 18, false, 349m, "Running-focused watch", "Garmin Forerunner 255" },
                    { 55, 4, 10, false, 799m, "Premium outdoor GPS watch", "Garmin Fenix 7" },
                    { 56, 5, 50, false, 249m, "ANC wireless earbuds", "AirPods Pro 2" },
                    { 57, 5, 20, false, 549m, "Premium over-ear headphones", "AirPods Max" },
                    { 58, 5, 25, false, 349m, "Top ANC headphones", "Sony WH-1000XM5" },
                    { 59, 5, 35, false, 299m, "Premium earbuds", "Sony WF-1000XM5" },
                    { 60, 5, 30, false, 199m, "Samsung ANC earbuds", "Samsung Galaxy Buds 2 Pro" },
                    { 61, 5, 40, false, 149m, "Wireless over-ear", "JBL Live 660NC" },
                    { 62, 5, 45, false, 79m, "Budget ANC earbuds", "JBL Tune 230NC" },
                    { 63, 5, 18, false, 329m, "Premium ANC headset", "Bose QuietComfort 45" },
                    { 64, 5, 20, false, 299m, "High-end ANC earbuds", "Bose QuietComfort Earbuds II" },
                    { 65, 5, 50, false, 129m, "Affordable ANC earbuds", "Anker Soundcore Liberty 4" },
                    { 66, 5, 16, false, 349m, "Audiophile-grade ANC headset", "Sennheiser Momentum 4" },
                    { 67, 5, 35, false, 249m, "Fashionable wireless headphones", "Beats Studio3 Wireless" },
                    { 68, 5, 28, false, 199m, "Sports earbuds with ANC", "Beats Fit Pro" },
                    { 69, 5, 25, false, 169m, "Gaming ANC earbuds", "Razer Hammerhead Pro" },
                    { 70, 5, 22, false, 129m, "Professional gaming headset", "Logitech G Pro X" },
                    { 71, 6, 15, false, 499m, "Sony next-gen console", "PlayStation 5" },
                    { 72, 6, 20, false, 399m, "Digital-only PS5", "PlayStation 5 Digital" },
                    { 73, 6, 18, false, 499m, "Powerful Microsoft console", "Xbox Series X" },
                    { 74, 6, 25, false, 299m, "Affordable Xbox console", "Xbox Series S" },
                    { 75, 6, 22, false, 349m, "Hybrid gaming console", "Nintendo Switch OLED" },
                    { 76, 6, 30, false, 199m, "Portable-only Nintendo console", "Nintendo Switch Lite" },
                    { 77, 6, 15, false, 499m, "Valve portable gaming PC", "Steam Deck OLED" },
                    { 78, 6, 12, false, 599m, "Portable Windows gaming device", "ASUS ROG Ally" },
                    { 79, 6, 10, false, 549m, "Sony VR headset", "PlayStation VR2" },
                    { 80, 6, 16, false, 499m, "Standalone VR headset", "Meta Quest 3" },
                    { 81, 7, 40, false, 99m, "Premium wireless mouse", "Logitech MX Master 3S" },
                    { 82, 7, 35, false, 119m, "Professional wireless keyboard", "Logitech MX Keys" },
                    { 83, 7, 32, false, 69m, "High-performance gaming mouse", "Razer DeathAdder V3" },
                    { 84, 7, 12, false, 229m, "Premium mechanical keyboard", "Corsair K100 RGB" },
                    { 85, 7, 18, false, 199m, "Gaming mechanical keyboard", "SteelSeries Apex Pro" },
                    { 86, 7, 28, false, 79m, "Professional webcam", "Logitech C920 HD Webcam" },
                    { 87, 7, 22, false, 149m, "Creator control panel", "Elgato Stream Deck" },
                    { 88, 7, 50, false, 49m, "Portable power bank", "Anker PowerCore 20k" },
                    { 89, 7, 35, false, 59m, "Laptop hub expansion", "Anker USB-C Hub 7-in-1" },
                    { 90, 7, 55, false, 29m, "Fast USB-C charger", "Samsung 25W Super Fast Charger" },
                    { 91, 7, 30, false, 59m, "Fast MacBook charger", "Apple USB-C 70W Charger" },
                    { 92, 7, 100, false, 19m, "Phone car holder", "Baseus Magnetic Car Mount" },
                    { 93, 7, 200, false, 12m, "High-speed charging cable", "UGREEN USB-C Cable 100W" },
                    { 94, 7, 22, false, 129m, "Portable SSD storage", "Sandisk Extreme 1TB SSD" },
                    { 95, 7, 15, false, 249m, "Ultra-fast NVMe SSD", "WD Black SN850 2TB" },
                    { 96, 7, 25, false, 99m, "Gaming headset", "HyperX Cloud II" },
                    { 97, 7, 40, false, 49m, "Gaming mouse", "Logitech G502 Hero" },
                    { 98, 7, 30, false, 49m, "RGB gaming pad", "Razer Firefly RGB Mousepad" },
                    { 99, 7, 20, false, 159m, "Rugged portable SSD", "Samsung T7 Shield SSD" },
                    { 100, 7, 10, false, 249m, "Premium 4K player", "Sony 4K Blu-ray Player" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_Id",
                table: "Products",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_Id",
                table: "Categories",
                column: "Id",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Products_Id",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Categories_Id",
                table: "Categories");

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
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100);

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

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
