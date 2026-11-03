using System;
using System.Collections.Generic;
using System.Linq;

namespace MiniWarehouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<string> productNames = new List<string>() { "Laptop", "PC", "Mobile" };
            List<int> priceProducts = new List<int>() { 500, 200, 150 };

            int userInput = 0;

            while (userInput != 5)
            {
                Console.WriteLine("\n==========================================");
                Console.WriteLine("Please choose an option:");
                Console.WriteLine("1. Show all products");
                Console.WriteLine("2. Add new product");
                Console.WriteLine("3. Search product");
                Console.WriteLine("4. Calculate total warehouse value");
                Console.WriteLine("5. Exit");
                Console.WriteLine("==========================================");
                Console.Write("Enter your choice (1-5): ");

                if (!int.TryParse(Console.ReadLine(), out userInput))
                {
                    Console.WriteLine("Error: Please enter a valid number between 1 and 5.");
                    continue;
                }

                switch (userInput)
                {
                    case 1:
                        if (productNames.Count == 0)
                        {
                            Console.WriteLine("Warehouse is currently empty.");
                        }
                        else
                        {
                            Console.WriteLine("\n--- Warehouse Products ---");
                            for (int i = 0; i < productNames.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {productNames[i]} - ${priceProducts[i]}");
                            }
                        }
                        break;

                    case 2:
                        Console.Write("Enter product name: ");
                        string userInputProductName = Console.ReadLine().Trim();

                        Console.Write("Enter product price ($): ");
                        if (int.TryParse(Console.ReadLine(), out int userInputProductPrice) && userInputProductPrice > 0)
                        {
                            productNames.Add(userInputProductName);
                            priceProducts.Add(userInputProductPrice);
                            Console.WriteLine("Product added successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Error: Price must be a positive number greater than 0.");
                        }
                        break;

                    case 3:
                        Console.Write("Enter search keyword: ");
                        string search = Console.ReadLine().Trim().ToLower();

                        bool found = false;
                        for (int i = 0; i < productNames.Count; i++)
                        {
                            if (productNames[i].ToLower().Contains(search))
                            {
                                Console.WriteLine($"Found: {productNames[i]} | Price: ${priceProducts[i]}");
                                found = true;
                            }
                        }

                        if (!found)
                        {
                            Console.WriteLine("No products found matching your search.");
                        }
                        break;

                    case 4:
                        int CalculateTotalWarehouseValue(List<int> prices)
                        {
                            return prices.Sum();
                        }

                        int totalValue = CalculateTotalWarehouseValue(priceProducts);
                        Console.WriteLine($"Total warehouse value: ${totalValue}");
                        break;

                    case 5:
                        break;

                    default:
                        Console.WriteLine("Invalid option! Please enter a number between 1 and 5.");
                        break;
                }
            }

            Console.WriteLine("\nThank you for using Mini Warehouse. Goodbye!");
        }
    }
}
