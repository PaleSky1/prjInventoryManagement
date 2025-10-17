using System;
using System.Collections.Generic;
using System.Linq;

namespace prjInventoryManagement
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }

    public static class InventoryExtensions
    {
        public static decimal CalculateTotalValue(this List<Product> products)
        {
            return products.Sum(p => p.Quantity * p.Price);
        }
        public static List<Product> FilterLowStock(this List<Product> products, int threshold = 10)
        {
            return products.Where(p => p.Quantity < threshold).ToList();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Product> inventory = new List<Product>
            {
                new Product { ID = 1, Name = "Laptop", Quantity = 5, Price = 999.99m },
                new Product { ID = 2, Name = "Mouse", Quantity = 50, Price = 29.99m },
                new Product { ID = 3, Name = "Keyboard", Quantity = 8, Price = 79.99m },
                new Product { ID = 4, Name = "Monitor", Quantity = 12, Price = 299.99m },
                new Product { ID = 5, Name = "USB Cable", Quantity = 3, Price = 9.99m }
            };

            Console.WriteLine("========== INVENTORY MANAGEMENT SYSTEM ==========\n");

            Console.WriteLine("--- ALL PRODUCTS ---");
            foreach (var product in inventory)
            {
                Console.WriteLine($"ID: {product.ID}, Name: {product.Name}, Qty: {product.Quantity}, Price: R{product.Price}");
            }

            Console.WriteLine();

            decimal totalValue = inventory.CalculateTotalValue();
            Console.WriteLine($"Total Inventory Value: R{totalValue:F2}\n");

            List<Product> lowStockItems = inventory.FilterLowStock();
            Console.WriteLine("--- LOW STOCK ITEMS (< 10 units) ---");
            foreach (var item in lowStockItems)
            {
                Console.WriteLine($"{item.Name}: {item.Quantity} units");
            }

            Console.WriteLine();

            var productInfo = inventory
                .Select(p => new { p.Name, p.Price })
                .OrderByDescending(p => p.Price)      
                .ToList();

            Console.WriteLine("--- PRODUCT NAMES AND PRICES (Ordered by Price) ---");
            foreach (var info in productInfo)
            {
                Console.WriteLine($"{info.Name}: ${info.Price:F2}");
            }

            Console.WriteLine();

            var advancedInfo = inventory
                .Where(p => p.Quantity > 0)
                .Select(p => new
                {
                    p.Name,
                    p.Quantity,
                    p.Price,
                    TotalValue = p.Quantity * p.Price
                })
                .ToList();

            Console.WriteLine("--- DETAILED INVENTORY WITH TOTAL VALUES ---");
            foreach (var item in advancedInfo)
            {
                Console.WriteLine($"{item.Name} - Qty: {item.Quantity}, Unit Price: ${item.Price:F2}, Total: ${item.TotalValue:F2}");
            }

            Console.WriteLine("\n========== END OF INVENTORY REPORT ==========");
        }
    }
}