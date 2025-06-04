using Microsoft.EntityFrameworkCore;

namespace OrderApp.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new AppDbContext(serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>());

        if (context.Orders.Any())
        {
            return;
        }

        context.Products.AddRange(
            new Product { Name = "MindSync", Description = "MindSync is a neural implant that taps directly into your consciousness, blurring the line between mind and machine. It unlocks hidden depths of cognitive power, subtly altering your thoughts as it weaves its influence into every aspect of your reality.", Price = 1995.99M},
            new Product { Name = "Seraphine", Description = "Seraphine is an advanced AI assistant that quietly monitors your every move, anticipating your needs before you even voice them. Always listening, always watching, Seraphine seamlessly weaves itself into your life, guiding your actions with an eerie, almost omnipresent precision.", Price = 200M},
            new Product { Name = "SoulSear", Description = "SoulSear is an advanced energy weapon engineered for maximum operational efficiency and strategic dominance on the battlefield. Designed with cutting-edge targeting systems and optimized for high-intensity impact, SoulSear delivers unparalleled precision and lethality, ensuring superior tactical performance for elite military and defense operations.", Price = 43000000M},
            new Product { Name = "PhantomClaw", Description = "PhantomClaw is a next-generation gaming mouse, designed with advanced precision technology that adapts to your every move, almost as if it knows your intentions before you do. Beneath its sleek exterior lies a hidden power, subtly guiding your gameplay with an unsettling accuracy, making you question who's really in control.", Price = 99.95M}
        );

        context.SaveChanges();

        List<Order> orders = new List<Order>
        {
            new Order { CustomerName = "United States Department of Defense", OrderDate = DateTime.Parse("2024-05-15"), ZipCode = "20301" },
            new Order { CustomerName = "UK Ministry of Defence", OrderDate = DateTime.Parse("2024-06-23"), ZipCode = "10001" },
            new Order { CustomerName = "Germany Bundeswehr", OrderDate = DateTime.Parse("2024-07-10"), ZipCode = "10002" },
            new Order { CustomerName = "Google Inc.", OrderDate = DateTime.Parse("2024-03-05"), ZipCode = "94043" },
            new Order { CustomerName = "Amazon Web Services", OrderDate = DateTime.Parse("2024-01-12"), ZipCode = "98109" },
            new Order { CustomerName = "French Armed Forces", OrderDate = DateTime.Parse("2024-02-18"), ZipCode = "10003" },
            new Order { CustomerName = "Canadian Department of National Defence", OrderDate = DateTime.Parse("2024-04-22"), ZipCode = "10004" },
            new Order { CustomerName = "Australian Defence Force", OrderDate = DateTime.Parse("2024-03-29"), ZipCode = "10005" },
            new Order { CustomerName = "Apple Inc.", OrderDate = DateTime.Parse("2024-07-03"), ZipCode = "95014" },
            new Order { CustomerName = "Tesla, Inc.", OrderDate = DateTime.Parse("2024-06-15"), ZipCode = "94304" },
            new Order { CustomerName = "NATO", OrderDate = DateTime.Parse("2024-08-01"), ZipCode = "10006" },
            new Order { CustomerName = "Brazilian Ministry of Defence", OrderDate = DateTime.Parse("2024-05-10"), ZipCode = "10007" },
            new Order { CustomerName = "British Army", OrderDate = DateTime.Parse("2024-09-25"), ZipCode = "10008" },
            new Order { CustomerName = "SpaceX", OrderDate = DateTime.Parse("2024-04-17"), ZipCode = "90250" },
            new Order { CustomerName = "Russian Armed Forces", OrderDate = DateTime.Parse("2024-06-28"), ZipCode = "10009" },
            new Order { CustomerName = "Chinese People's Liberation Army", OrderDate = DateTime.Parse("2024-05-04"), ZipCode = "10010" },
            new Order { CustomerName = "Samsung Electronics", OrderDate = DateTime.Parse("2024-01-25"), ZipCode = "10011" },
            new Order { CustomerName = "French Navy", OrderDate = DateTime.Parse("2024-02-11"), ZipCode = "10012" },
            new Order { CustomerName = "United Nations", OrderDate = DateTime.Parse("2024-03-08"), ZipCode = "10013" },
            new Order { CustomerName = "Facebook, Inc.", OrderDate = DateTime.Parse("2024-08-20"), ZipCode = "10014" },
            new Order { CustomerName = "German Air Force", OrderDate = DateTime.Parse("2024-06-09"), ZipCode = "10015" },
            new Order { CustomerName = "Dell Technologies", OrderDate = DateTime.Parse("2024-05-12"), ZipCode = "10016" },
            new Order { CustomerName = "Israeli Defense Forces", OrderDate = DateTime.Parse("2024-02-05"), ZipCode = "10017" },
            new Order { CustomerName = "IBM", OrderDate = DateTime.Parse("2024-03-18"), ZipCode = "10018" },
            new Order { CustomerName = "Oracle Corporation", OrderDate = DateTime.Parse("2024-08-15"), ZipCode = "10019" },
            new Order { CustomerName = "NVIDIA Corporation", OrderDate = DateTime.Parse("2024-07-26"), ZipCode = "10020" },
            new Order { CustomerName = "British Royal Navy", OrderDate = DateTime.Parse("2024-09-01"), ZipCode = "10021" },
            new Order { CustomerName = "Google Cloud", OrderDate = DateTime.Parse("2024-10-05"), ZipCode = "10022" },
            new Order { CustomerName = "Swedish Armed Forces", OrderDate = DateTime.Parse("2024-03-02"), ZipCode = "10023" },
            new Order { CustomerName = "Japan Self-Defense Forces", OrderDate = DateTime.Parse("2024-04-03"), ZipCode = "10024" },
            new Order { CustomerName = "Spanish Army", OrderDate = DateTime.Parse("2024-02-26"), ZipCode = "10025" },
            new Order { CustomerName = "South African National Defence Force", OrderDate = DateTime.Parse("2024-09-17"), ZipCode = "10026" },
            new Order { CustomerName = "Canadian Armed Forces", OrderDate = DateTime.Parse("2024-01-14"), ZipCode = "10027" },
            new Order { CustomerName = "HP Inc.", OrderDate = DateTime.Parse("2024-02-22"), ZipCode = "10028" },
            new Order { CustomerName = "Cisco Systems", OrderDate = DateTime.Parse("2024-07-18"), ZipCode = "10029" },
            new Order { CustomerName = "Sony Corporation", OrderDate = DateTime.Parse("2024-08-08"), ZipCode = "10030" },
            new Order { CustomerName = "Accenture plc", OrderDate = DateTime.Parse("2024-01-19"), ZipCode = "10031" },
            new Order { CustomerName = "Australian Navy", OrderDate = DateTime.Parse("2024-06-21"), ZipCode = "10032" },
            new Order { CustomerName = "Netherlands Armed Forces", OrderDate = DateTime.Parse("2024-07-11"), ZipCode = "10033" },
            new Order { CustomerName = "South Korean Military", OrderDate = DateTime.Parse("2024-09-12"), ZipCode = "10034" },
            new Order { CustomerName = "Mexican Armed Forces", OrderDate = DateTime.Parse("2024-03-25"), ZipCode = "10035" },
            new Order { CustomerName = "Panasonic Corporation", OrderDate = DateTime.Parse("2024-05-18"), ZipCode = "10036" },
            new Order { CustomerName = "Italian Armed Forces", OrderDate = DateTime.Parse("2024-04-13"), ZipCode = "10037" },
            new Order { CustomerName = "Hitachi, Ltd.", OrderDate = DateTime.Parse("2024-01-30"), ZipCode = "10038" },
            new Order { CustomerName = "Egyptian Army", OrderDate = DateTime.Parse("2024-07-30"), ZipCode = "10039" },
            new Order { CustomerName = "French Air Force", OrderDate = DateTime.Parse("2024-09-22"), ZipCode = "10040" },
            new Order { CustomerName = "Philips N.V.", OrderDate = DateTime.Parse("2024-05-23"), ZipCode = "10041" },
            new Order { CustomerName = "Norwegian Armed Forces", OrderDate = DateTime.Parse("2024-06-07"), ZipCode = "10042" },
            new Order { CustomerName = "Indian Armed Forces", OrderDate = DateTime.Parse("2024-03-13"), ZipCode = "10043" },
            new Order { CustomerName = "The Korean People's Army", OrderDate = DateTime.Parse("2024-10-17"), ZipCode = "10044" }
        };

        context.AddRange(orders);
        context.SaveChanges();

        List<ProductOrder> productOrders = new List<ProductOrder>
        {
            // Order 1 contains 3 products
            new ProductOrder { OrderID = 1, ProductID = 1 },
            new ProductOrder { OrderID = 1, ProductID = 2 },
            new ProductOrder { OrderID = 1, ProductID = 3 },

            // Order 2 contains 2 products
            new ProductOrder { OrderID = 2, ProductID = 2 },
            new ProductOrder { OrderID = 2, ProductID = 4 },

            // Order 3 contains 1 product
            new ProductOrder { OrderID = 3, ProductID = 4 },

            // Order 4 contains 4 products
            new ProductOrder { OrderID = 4, ProductID = 1 },
            new ProductOrder { OrderID = 4, ProductID = 3 },
            new ProductOrder { OrderID = 4, ProductID = 4 },
            new ProductOrder { OrderID = 4, ProductID = 2 },

            // Order 5 contains 5 products
            new ProductOrder { OrderID = 5, ProductID = 1 },
            new ProductOrder { OrderID = 5, ProductID = 2 },
            new ProductOrder { OrderID = 5, ProductID = 3 },
            new ProductOrder { OrderID = 5, ProductID = 4 },

            // Order 6 contains 2 products
            new ProductOrder { OrderID = 6, ProductID = 3 },
            new ProductOrder { OrderID = 6, ProductID = 4 },

            // Order 7 contains 3 products
            new ProductOrder { OrderID = 7, ProductID = 2 },
            new ProductOrder { OrderID = 7, ProductID = 3 },
            new ProductOrder { OrderID = 7, ProductID = 1 },

            // Order 8 contains 1 product
            new ProductOrder { OrderID = 8, ProductID = 1 },

            // Order 9 contains 2 products
            new ProductOrder { OrderID = 9, ProductID = 1 },
            new ProductOrder { OrderID = 9, ProductID = 2 },

            // Order 10 contains 3 products
            new ProductOrder { OrderID = 10, ProductID = 3 },
            new ProductOrder { OrderID = 10, ProductID = 4 },
            new ProductOrder { OrderID = 10, ProductID = 1 },

            // Order 11 contains 1 product
            new ProductOrder { OrderID = 11, ProductID = 1 },

            // Order 12 contains 3 products
            new ProductOrder { OrderID = 12, ProductID = 2 },
            new ProductOrder { OrderID = 12, ProductID = 3 },
            new ProductOrder { OrderID = 12, ProductID = 4 },

            // Order 13 contains 2 products
            new ProductOrder { OrderID = 13, ProductID = 1 },
            new ProductOrder { OrderID = 13, ProductID = 3 },

            // Order 14 contains 4 products
            new ProductOrder { OrderID = 14, ProductID = 2 },
            new ProductOrder { OrderID = 14, ProductID = 3 },
            new ProductOrder { OrderID = 14, ProductID = 4 },

            // Order 15 contains 2 products
            new ProductOrder { OrderID = 15, ProductID = 1 },
            new ProductOrder { OrderID = 15, ProductID = 4 },

            // Order 16 contains 3 products
            new ProductOrder { OrderID = 16, ProductID = 2 },
            new ProductOrder { OrderID = 16, ProductID = 3 },
            new ProductOrder { OrderID = 16, ProductID = 4 },

            // Order 17 contains 1 product
            new ProductOrder { OrderID = 17, ProductID = 4 },

            // Order 18 contains 2 products
            new ProductOrder { OrderID = 18, ProductID = 1 },
            new ProductOrder { OrderID = 18, ProductID = 3 },

            // Order 19 contains 4 products
            new ProductOrder { OrderID = 19, ProductID = 2 },
            new ProductOrder { OrderID = 19, ProductID = 4 },
            new ProductOrder { OrderID = 19, ProductID = 3 },

            // Order 20 contains 5 products
            new ProductOrder { OrderID = 20, ProductID = 1 },
            new ProductOrder { OrderID = 20, ProductID = 2 },
            new ProductOrder { OrderID = 20, ProductID = 3 },
            new ProductOrder { OrderID = 20, ProductID = 4 },

            // Order 21 contains 2 products
            new ProductOrder { OrderID = 21, ProductID = 1 },
            new ProductOrder { OrderID = 21, ProductID = 2 },

            // Order 22 contains 3 products
            new ProductOrder { OrderID = 22, ProductID = 2 },
            new ProductOrder { OrderID = 22, ProductID = 3 },
            new ProductOrder { OrderID = 22, ProductID = 4 },

            // Order 23 contains 2 products
            new ProductOrder { OrderID = 23, ProductID = 1 },
            new ProductOrder { OrderID = 23, ProductID = 2 },

            // Order 24 contains 4 products
            new ProductOrder { OrderID = 24, ProductID = 3 },
            new ProductOrder { OrderID = 24, ProductID = 4 },
            new ProductOrder { OrderID = 24, ProductID = 1 },

            // Order 25 contains 5 products
            new ProductOrder { OrderID = 25, ProductID = 2 },
            new ProductOrder { OrderID = 25, ProductID = 3 },
            new ProductOrder { OrderID = 25, ProductID = 4 },
            new ProductOrder { OrderID = 25, ProductID = 1 },

            new ProductOrder { OrderID = 26, ProductID = 1 },
            new ProductOrder { OrderID = 26, ProductID = 3 },

            new ProductOrder { OrderID = 27, ProductID = 2 },
            new ProductOrder { OrderID = 27, ProductID = 4 },

            new ProductOrder { OrderID = 28, ProductID = 1 },
            new ProductOrder { OrderID = 28, ProductID = 2 },
            new ProductOrder { OrderID = 28, ProductID = 4 },

            new ProductOrder { OrderID = 29, ProductID = 3 },
            new ProductOrder { OrderID = 29, ProductID = 4 },

            new ProductOrder { OrderID = 30, ProductID = 1 },
            new ProductOrder { OrderID = 30, ProductID = 2 },
            new ProductOrder { OrderID = 30, ProductID = 3 },
            new ProductOrder { OrderID = 30, ProductID = 4 },

            new ProductOrder { OrderID = 31, ProductID = 1 },

            new ProductOrder { OrderID = 32, ProductID = 1 },
            new ProductOrder { OrderID = 32, ProductID = 4 },

            new ProductOrder { OrderID = 33, ProductID = 2 },
            new ProductOrder { OrderID = 33, ProductID = 3 },

            new ProductOrder { OrderID = 34, ProductID = 1 },
            new ProductOrder { OrderID = 34, ProductID = 2 },
            new ProductOrder { OrderID = 34, ProductID = 3 },
   
            new ProductOrder { OrderID = 35, ProductID = 4 },

            new ProductOrder { OrderID = 36, ProductID = 3 },
            new ProductOrder { OrderID = 36, ProductID = 4 },

            new ProductOrder { OrderID = 37, ProductID = 1 },
            new ProductOrder { OrderID = 37, ProductID = 2 },
            new ProductOrder { OrderID = 37, ProductID = 4 },

            new ProductOrder { OrderID = 38, ProductID = 1 },

            new ProductOrder { OrderID = 39, ProductID = 2 },
            new ProductOrder { OrderID = 39, ProductID = 3 },
            new ProductOrder { OrderID = 39, ProductID = 4 },

            new ProductOrder { OrderID = 40, ProductID = 1 },
            new ProductOrder { OrderID = 40, ProductID = 3 },

            new ProductOrder { OrderID = 41, ProductID = 3 },
            new ProductOrder { OrderID = 41, ProductID = 4 },

            new ProductOrder { OrderID = 42, ProductID = 2 },
            new ProductOrder { OrderID = 42, ProductID = 3 },

            new ProductOrder { OrderID = 43, ProductID = 1 },
            new ProductOrder { OrderID = 43, ProductID = 3 },
            new ProductOrder { OrderID = 43, ProductID = 4 },

            new ProductOrder { OrderID = 44, ProductID = 2 },

            new ProductOrder { OrderID = 45, ProductID = 1 },
            new ProductOrder { OrderID = 45, ProductID = 2 },

            new ProductOrder { OrderID = 46, ProductID = 3 },
            new ProductOrder { OrderID = 46, ProductID = 4 },

            new ProductOrder { OrderID = 47, ProductID = 1 },
            new ProductOrder { OrderID = 47, ProductID = 3 },
            new ProductOrder { OrderID = 47, ProductID = 4 },

            new ProductOrder { OrderID = 48, ProductID = 2 },
            new ProductOrder { OrderID = 48, ProductID = 3 },

            new ProductOrder { OrderID = 49, ProductID = 1 },
            new ProductOrder { OrderID = 49, ProductID = 4 },

            new ProductOrder { OrderID = 50, ProductID = 2 },
            new ProductOrder { OrderID = 50, ProductID = 3 }
        };

        context.AddRange(productOrders);
        context.SaveChanges();
    }
}