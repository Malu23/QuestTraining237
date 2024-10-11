using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day9_111024
{
    internal class ProgramDay1
    {
        static Dictionary<string, Dictionary<string, string>> products = new Dictionary<string, Dictionary<string, string>>();

        static void AddProduct()
        {
            Console.WriteLine("Enter product name:");
            var name = Console.ReadLine();

            Console.WriteLine("Enter the price of product:");
            var price = Console.ReadLine();

            Console.WriteLine("Enter the stock of product:");
            var stock = Console.ReadLine();

            // Generating unique ID for the product.
            var id = Guid.NewGuid().ToString();

            var product = new Dictionary<string, string>
            {
                { "Name", name },
                { "Price", price },
                { "Stock", stock }
            };

            products[id] = product;
            Console.WriteLine($"Product added successfully: {id}");
        }

        static void UpdateStock()
        {
            Console.WriteLine("Enter Product ID to update stock:");
            string id = Console.ReadLine();

            if (products.ContainsKey(id))
            {
                Console.WriteLine("Enter new stock quantity:");
                string newStock = Console.ReadLine();

                products[id]["Stock"] = newStock;
                Console.WriteLine("Stock updated successfully!");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        static void GetProductData()
        {
            Console.WriteLine("Enter Product ID:");
            string id = Console.ReadLine();

            if (products.ContainsKey(id))
            {
                var product = products[id];

                Console.WriteLine("Name: " + product["Name"]);
                Console.WriteLine("Price: " + product["Price"]);
                Console.WriteLine("Stock: " + product["Stock"]);
            }
            else
            {
                Console.WriteLine("Patient not found.");
            }
        }

        static void GetLowStockProducts()
        {
            Console.WriteLine("Enter stock threshold:");
            int threshold = int.Parse(Console.ReadLine());

            Console.WriteLine("Low stock products:");
            foreach (var product in products)
            {
                int stock;
                if (int.TryParse(product.Value["Stock"], out stock))
                {
                    if (stock < threshold)
                    {
                        Console.WriteLine("Product ID: " + product.Key);
                        Console.WriteLine("Name: " + product.Value["Name"]);
                        Console.WriteLine("Stock: " + product.Value["Stock"]);
                    }
                }
            }
        }

        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Update Stock");
                Console.WriteLine("3. Get Product Data");
                Console.WriteLine("4. Get Low Stock Products");
                Console.WriteLine("5. Exit");
                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddProduct();
                        break;
                    case "2":
                        UpdateStock();
                        break;
                    case "3":
                        GetProductData();
                        break;
                    case "4":
                        GetLowStockProducts();
                        break;
                    case "5":
                        Console.WriteLine("Exiting the program.");
                        return;
                    default:
                        Console.WriteLine("Invalid case");
                        break;
                }
            }
        }
    }
}
