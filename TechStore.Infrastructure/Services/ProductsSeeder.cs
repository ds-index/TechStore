using TechStore.Domain.Entities;

namespace TechStore.Infrastructure.Services
{
    public class ProductsSeeder
    {
        public static List<ProductDomain> Gen()
        {
            var products = new List<ProductDomain>
            {
    // 1–20 Smartphones
                new ProductDomain { Id =1, ProductName = "iPhone 15 Pro Max", ProductDescription = "Apple flagship smartphone", Price = 1199, Inventory = 20, CategoryId = 1 },
                new ProductDomain { Id =2, ProductName = "iPhone 14", ProductDescription = "Apple previous generation phone", Price = 799, Inventory = 25, CategoryId = 1 },
                new ProductDomain { Id =3, ProductName = "Samsung Galaxy S24 Ultra", ProductDescription = "Samsung top-tier phone", Price = 1099, Inventory = 18, CategoryId = 1 },
                new ProductDomain { Id =4, ProductName = "Samsung Galaxy S23", ProductDescription = "High-end Samsung smartphone", Price = 799, Inventory = 22, CategoryId = 1 },
                new ProductDomain { Id =5, ProductName = "Google Pixel 8 Pro", ProductDescription = "Google AI-powered flagship", Price = 999, Inventory = 15, CategoryId = 1 },
                new ProductDomain { Id =6, ProductName = "Google Pixel 7", ProductDescription = "Affordable flagship experience", Price = 599, Inventory = 28, CategoryId = 1 },
                new ProductDomain { Id =7, ProductName = "Xiaomi 14 Pro", ProductDescription = "Xiaomi premium phone with Leica camera", Price = 799, Inventory = 30, CategoryId = 1 },
                new ProductDomain { Id =8, ProductName = "Xiaomi Redmi Note 12 Pro", ProductDescription = "Best mid-range Xiaomi device", Price = 299, Inventory = 40, CategoryId = 1 },
                new ProductDomain { Id =9, ProductName = "OnePlus 12", ProductDescription = "High-performance flagship killer", Price = 699, Inventory = 20, CategoryId = 1 },
                new ProductDomain { Id =10, ProductName = "OnePlus Nord CE 3", ProductDescription = "Mid-range OnePlus smartphone", Price = 329, Inventory = 35, CategoryId = 1 },
                new ProductDomain { Id =11, ProductName = "Huawei P60 Pro", ProductDescription = "Premium camera-focused smartphone", Price = 899, Inventory = 12, CategoryId = 1 },
                new ProductDomain { Id =12, ProductName = "Huawei Nova 11", ProductDescription = "Stylish mid-range smartphone", Price = 399, Inventory = 25, CategoryId = 1 },
                new ProductDomain { Id =13, ProductName = "Sony Xperia 1 V", ProductDescription = "Sony flagship with pro camera features", Price = 1299, Inventory = 10, CategoryId = 1 },
                new ProductDomain { Id =14, ProductName = "Sony Xperia 5 V", ProductDescription = "Compact premium smartphone", Price = 799, Inventory = 14, CategoryId = 1 },
                new ProductDomain { Id = 15, ProductName = "Nokia X30", ProductDescription = "Eco-friendly smartphone", Price = 499, Inventory = 18, CategoryId = 1 },
                new ProductDomain { Id =16, ProductName = "Motorola Edge 40 Pro", ProductDescription = "Motorola flagship smartphone", Price = 899, Inventory = 20, CategoryId = 1 },
                new ProductDomain {Id =17, ProductName = "Motorola Moto G Power 2023", ProductDescription = "Affordable phone with long battery", Price = 199, Inventory = 45, CategoryId = 1 },
                new ProductDomain {Id =18, ProductName = "Asus ROG Phone 7", ProductDescription = "Gaming smartphone beast", Price = 999, Inventory = 12, CategoryId = 1 },
                new ProductDomain {Id =19, ProductName = "Nothing Phone 2", ProductDescription = "Unique transparent design phone", Price = 599, Inventory = 22, CategoryId = 1 },
                new ProductDomain {Id =20, ProductName = "Realme GT 5 Pro", ProductDescription = "Affordable flagship performance", Price = 549, Inventory = 26, CategoryId = 1 },
                    // 21–35 Laptops
                new ProductDomain {Id =21, ProductName = "MacBook Air M3", ProductDescription = "Lightweight Apple laptop", Price = 1299, Inventory = 15, CategoryId = 2 },
                new ProductDomain {Id =22, ProductName = "MacBook Pro 16 M3 Max", ProductDescription = "Apple high-performance laptop", Price = 3499, Inventory = 8, CategoryId = 2 },
                new ProductDomain {Id =23, ProductName = "MacBook Pro 14 M3", ProductDescription = "Apple portable powerhouse", Price = 2199, Inventory = 12, CategoryId = 2 },
                new ProductDomain {Id =24, ProductName = "Dell XPS 15", ProductDescription = "Dell premium ultrabook", Price = 1799, Inventory = 10, CategoryId = 2 },
                new ProductDomain {Id =25, ProductName = "Dell Inspiron 14", ProductDescription = "Affordable laptop for students", Price = 599, Inventory = 22, CategoryId = 2 },
                new ProductDomain {Id =26, ProductName = "HP Spectre x360", ProductDescription = "Premium 2-in-1 ultrabook", Price = 1599, Inventory = 11, CategoryId = 2 },
                new ProductDomain {Id =27, ProductName = "HP Pavilion 15", ProductDescription = "Budget-friendly laptop", Price = 499, Inventory = 30, CategoryId = 2 },
                new ProductDomain {Id =28, ProductName = "Lenovo ThinkPad X1 Carbon", ProductDescription = "Business ultrabook", Price = 1699, Inventory = 14, CategoryId = 2 },
                new ProductDomain {Id =29, ProductName = "Lenovo Legion 7", ProductDescription = "High-end gaming laptop", Price = 2299, Inventory = 9, CategoryId = 2 },
                new ProductDomain {Id =30, ProductName = "ASUS ROG Zephyrus G14", ProductDescription = "Compact gaming laptop", Price = 1599, Inventory = 12, CategoryId = 2 },
                new ProductDomain {Id =31, ProductName = "ASUS VivoBook S15", ProductDescription = "Affordable ultrabook", Price = 699, Inventory = 18, CategoryId = 2 },
                new ProductDomain {Id =32, ProductName = "Acer Swift 3", ProductDescription = "Lightweight student laptop", Price = 649, Inventory = 20, CategoryId = 2 },
                new ProductDomain {Id =33, ProductName = "Acer Predator Helios 300", ProductDescription = "Mid-range gaming laptop", Price = 1399, Inventory = 15, CategoryId = 2 },
                new ProductDomain {Id =34, ProductName = "MSI Stealth 16 Studio", ProductDescription = "Professional creator laptop", Price = 1999, Inventory = 10, CategoryId = 2 },
                new ProductDomain {Id =35, ProductName = "Razer Blade 15", ProductDescription = "Premium gaming laptop", Price = 2499, Inventory = 8, CategoryId = 2 },

                    // 36–45 Tablets
                new ProductDomain {Id =36, ProductName = "iPad Pro 12.9 M2", ProductDescription = "Apple flagship tablet", Price = 1299, Inventory = 14, CategoryId = 3 },
                new ProductDomain {Id =37, ProductName = "iPad Air M1", ProductDescription = "Powerful lightweight tablet", Price = 599, Inventory = 20, CategoryId = 3 },
                new ProductDomain {Id =38, ProductName = "iPad 10th Gen", ProductDescription = "Affordable Apple tablet", Price = 449, Inventory = 25, CategoryId = 3 },
                new ProductDomain {Id =39, ProductName = "Samsung Galaxy Tab S9", ProductDescription = "Premium Android tablet", Price = 899, Inventory = 18, CategoryId = 3 },
                new ProductDomain {Id =40, ProductName = "Samsung Tab A8", ProductDescription = "Budget Android tablet", Price = 199, Inventory = 40, CategoryId = 3 },
                new ProductDomain {Id =41, ProductName = "Xiaomi Pad 6", ProductDescription = "Affordable power tablet", Price = 399, Inventory = 30, CategoryId = 3 },
                new ProductDomain {Id =42, ProductName = "Lenovo Tab P12 Pro", ProductDescription = "High-end productivity tablet", Price = 699, Inventory = 12, CategoryId = 3 },
                new ProductDomain {Id =43, ProductName = "Amazon Fire HD 10", ProductDescription = "Budget media tablet", Price = 149, Inventory = 35, CategoryId = 3 },
                new ProductDomain {Id =44, ProductName = "Huawei MatePad 11", ProductDescription = "Premium Huawei tablet", Price = 599, Inventory = 15, CategoryId = 3 },
                new ProductDomain {Id =45, ProductName = "Realme Pad 2", ProductDescription = "Affordable entertainment tablet", Price = 229, Inventory = 32, CategoryId = 3 },

                    // 46–55 Smart Watches
                new ProductDomain {Id =46, ProductName = "Apple Watch Series 9", ProductDescription = "Top smartwatch from Apple", Price = 399, Inventory = 28, CategoryId = 4 },
                new ProductDomain {Id =47, ProductName = "Apple Watch Ultra 2", ProductDescription = "Rugged smartwatch for professionals", Price = 799, Inventory = 12, CategoryId = 4 },
                new ProductDomain {Id =48, ProductName = "Samsung Galaxy Watch 6", ProductDescription = "Samsung premium smartwatch", Price = 349, Inventory = 26, CategoryId = 4 },
                new ProductDomain {Id =49, ProductName = "Samsung Galaxy Watch 6 Classic", ProductDescription = "Classic design smartwatch", Price = 399, Inventory = 22, CategoryId = 4 },
                new ProductDomain {Id =50, ProductName = "Huawei Watch GT 4", ProductDescription = "Long-lasting smartwatch", Price = 249, Inventory = 35, CategoryId = 4 },
                new ProductDomain {Id =51, ProductName = "Xiaomi Watch S1 Pro", ProductDescription = "Stylish Xiaomi smartwatch", Price = 199, Inventory = 40, CategoryId = 4 },
                new ProductDomain {Id =52,ProductName = "Amazfit GTR 4", ProductDescription = "Fitness and health smartwatch", Price = 179, Inventory = 45, CategoryId = 4 },
                new ProductDomain {Id =53, ProductName = "Fitbit Sense 2", ProductDescription = "Fitness-focused smartwatch", Price = 229, Inventory = 30, CategoryId = 4 },
                new ProductDomain {Id =54, ProductName = "Garmin Forerunner 255", ProductDescription = "Running-focused watch", Price = 349, Inventory = 18, CategoryId = 4 },
                new ProductDomain {Id = 55,  ProductName = "Garmin Fenix 7", ProductDescription = "Premium outdoor GPS watch", Price = 799, Inventory = 10, CategoryId = 4 },

                    // 56–70 Headphones
                new ProductDomain {Id =56, ProductName = "AirPods Pro 2", ProductDescription = "ANC wireless earbuds", Price = 249, Inventory = 50, CategoryId = 5 },
                new ProductDomain {Id =57, ProductName = "AirPods Max", ProductDescription = "Premium over-ear headphones", Price = 549, Inventory = 20, CategoryId = 5 },
                new ProductDomain {Id =58, ProductName = "Sony WH-1000XM5", ProductDescription = "Top ANC headphones", Price = 349, Inventory = 25, CategoryId = 5 },
                new ProductDomain {Id =59, ProductName = "Sony WF-1000XM5", ProductDescription = "Premium earbuds", Price = 299, Inventory = 35, CategoryId = 5 },
                new ProductDomain {Id =60, ProductName = "Samsung Galaxy Buds 2 Pro", ProductDescription = "Samsung ANC earbuds", Price = 199, Inventory = 30, CategoryId = 5 },
                new ProductDomain {Id =61, ProductName = "JBL Live 660NC", ProductDescription = "Wireless over-ear", Price = 149, Inventory = 40, CategoryId = 5 },
                new ProductDomain {Id =62, ProductName = "JBL Tune 230NC", ProductDescription = "Budget ANC earbuds", Price = 79, Inventory = 45, CategoryId = 5 },
                new ProductDomain {Id =63, ProductName = "Bose QuietComfort 45", ProductDescription = "Premium ANC headset", Price = 329, Inventory = 18, CategoryId = 5 },
                new ProductDomain {Id =64, ProductName = "Bose QuietComfort Earbuds II", ProductDescription = "High-end ANC earbuds", Price = 299, Inventory = 20, CategoryId = 5 },
                new ProductDomain {Id =65, ProductName = "Anker Soundcore Liberty 4", ProductDescription = "Affordable ANC earbuds", Price = 129, Inventory = 50, CategoryId = 5 },
                new ProductDomain {Id =66, ProductName = "Sennheiser Momentum 4", ProductDescription = "Audiophile-grade ANC headset", Price = 349, Inventory = 16, CategoryId = 5 },
                new ProductDomain {Id =67, ProductName = "Beats Studio3 Wireless", ProductDescription = "Fashionable wireless headphones", Price = 249, Inventory = 35, CategoryId = 5 },
                new ProductDomain {Id =68, ProductName = "Beats Fit Pro", ProductDescription = "Sports earbuds with ANC", Price = 199, Inventory = 28, CategoryId = 5 },
                new ProductDomain {Id =69, ProductName = "Razer Hammerhead Pro", ProductDescription = "Gaming ANC earbuds", Price = 169, Inventory = 25, CategoryId = 5 },
                new ProductDomain {Id =70, ProductName = "Logitech G Pro X", ProductDescription = "Professional gaming headset", Price = 129, Inventory = 22, CategoryId = 5 },

                    // 71–80 Gaming Consoles
                new ProductDomain {Id =71, ProductName = "PlayStation 5", ProductDescription = "Sony next-gen console", Price = 499, Inventory = 15, CategoryId = 6 },
                new ProductDomain {Id =72, ProductName = "PlayStation 5 Digital", ProductDescription = "Digital-only PS5", Price = 399, Inventory = 20, CategoryId = 6 },
                new ProductDomain {Id =73, ProductName = "Xbox Series X", ProductDescription = "Powerful Microsoft console", Price = 499, Inventory = 18, CategoryId = 6 },
                new ProductDomain {Id =74, ProductName = "Xbox Series S", ProductDescription = "Affordable Xbox console", Price = 299, Inventory = 25, CategoryId = 6 },
                new ProductDomain {Id =75,ProductName = "Nintendo Switch OLED", ProductDescription = "Hybrid gaming console", Price = 349, Inventory = 22, CategoryId = 6 },
                new ProductDomain {Id =76, ProductName = "Nintendo Switch Lite", ProductDescription = "Portable-only Nintendo console", Price = 199, Inventory = 30, CategoryId = 6 },
                new ProductDomain {Id =77, ProductName = "Steam Deck OLED", ProductDescription = "Valve portable gaming PC", Price = 499, Inventory = 15, CategoryId = 6 },
                new ProductDomain {Id =78, ProductName = "ASUS ROG Ally", ProductDescription = "Portable Windows gaming device", Price = 599, Inventory = 12, CategoryId = 6 },
                new ProductDomain {Id =79, ProductName = "PlayStation VR2", ProductDescription = "Sony VR headset", Price = 549, Inventory = 10, CategoryId = 6 },
                new ProductDomain {Id =80, ProductName = "Meta Quest 3", ProductDescription = "Standalone VR headset", Price = 499, Inventory = 16, CategoryId = 6 },

                    // 81–100 Accessories
                new ProductDomain {Id =81, ProductName = "Logitech MX Master 3S", ProductDescription = "Premium wireless mouse", Price = 99, Inventory = 40, CategoryId = 7 },
                new ProductDomain {Id =82, ProductName = "Logitech MX Keys", ProductDescription = "Professional wireless keyboard", Price = 119, Inventory = 35, CategoryId = 7 },
                new ProductDomain {Id =83, ProductName = "Razer DeathAdder V3", ProductDescription = "High-performance gaming mouse", Price = 69, Inventory = 32, CategoryId = 7 },
                new ProductDomain {Id =84, ProductName = "Corsair K100 RGB", ProductDescription = "Premium mechanical keyboard", Price = 229, Inventory = 12, CategoryId = 7 },
                new ProductDomain {Id =85, ProductName = "SteelSeries Apex Pro", ProductDescription = "Gaming mechanical keyboard", Price = 199, Inventory = 18, CategoryId = 7 },
                new ProductDomain {Id =86, ProductName = "Logitech C920 HD Webcam", ProductDescription = "Professional webcam", Price = 79, Inventory = 28, CategoryId = 7 },
                new ProductDomain {Id =87, ProductName = "Elgato Stream Deck", ProductDescription = "Creator control panel", Price = 149, Inventory = 22, CategoryId = 7 },
                new ProductDomain {Id =88, ProductName = "Anker PowerCore 20k", ProductDescription = "Portable power bank", Price = 49, Inventory = 50, CategoryId = 7 },
                new ProductDomain {Id =89, ProductName = "Anker USB-C Hub 7-in-1", ProductDescription = "Laptop hub expansion", Price = 59, Inventory = 35, CategoryId = 7 },
                new ProductDomain {Id =90, ProductName = "Samsung 25W Super Fast Charger", ProductDescription = "Fast USB-C charger", Price = 29, Inventory = 55, CategoryId = 7 },
                new ProductDomain {Id =91, ProductName = "Apple USB-C 70W Charger", ProductDescription = "Fast MacBook charger", Price = 59, Inventory = 30, CategoryId = 7 },
                new ProductDomain {Id =92, ProductName = "Baseus Magnetic Car Mount", ProductDescription = "Phone car holder", Price = 19, Inventory = 100, CategoryId = 7 },
                new ProductDomain {Id =93, ProductName = "UGREEN USB-C Cable 100W", ProductDescription = "High-speed charging cable", Price = 12, Inventory = 200, CategoryId = 7 },
                new ProductDomain {Id =94, ProductName = "Sandisk Extreme 1TB SSD", ProductDescription = "Portable SSD storage", Price = 129, Inventory = 22, CategoryId = 7 },
                new ProductDomain {Id =95, ProductName = "WD Black SN850 2TB", ProductDescription = "Ultra-fast NVMe SSD", Price = 249, Inventory = 15, CategoryId = 7 },
                new ProductDomain {Id =96, ProductName = "HyperX Cloud II", ProductDescription = "Gaming headset", Price = 99, Inventory = 25, CategoryId = 7 },
                new ProductDomain {Id =97, ProductName = "Logitech G502 Hero", ProductDescription = "Gaming mouse", Price = 49, Inventory = 40, CategoryId = 7 },
                new ProductDomain {Id =98, ProductName = "Razer Firefly RGB Mousepad", ProductDescription = "RGB gaming pad", Price = 49, Inventory = 30, CategoryId = 7 },
                new ProductDomain {Id =99, ProductName = "Samsung T7 Shield SSD", ProductDescription = "Rugged portable SSD", Price = 159, Inventory = 20, CategoryId = 7 },
                new ProductDomain {Id =100, ProductName = "Sony 4K Blu-ray Player", ProductDescription = "Premium 4K player", Price = 249, Inventory = 10, CategoryId = 7 },

        };

            return products;
        }
    }
}
