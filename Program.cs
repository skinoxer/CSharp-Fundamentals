using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
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
          
            int userInput = int.Parse(Console.ReadLine());
            List<string> ProductNames = new List<string>() { "laptop", "pc", "mobile" };
            List<int> priceProducts = new List<int>() { 500, 200, 150 };

            while (userInput != 5)
            {
                switch (userInput)
                {
                    case 1:

                        if (ProductNames.Count <= 0)
                        {
                            Console.WriteLine("warehouse is empty right now");
                        }
                        else
                        {
                             

                            for (int i = 0; i < ProductNames.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}.{ProductNames[i]} - {priceProducts[i]}$");
                            }
                        }
                        break;

                    case 2:
                        Console.WriteLine("enter name of the product");
                        string userInputProductName = Console.ReadLine().Trim();
                        Console.WriteLine("enter price of your product");

                        int userInputProductPrice = int.Parse(Console.ReadLine());
                        if (userInputProductPrice <= 0)
                        {
                            Console.WriteLine("price should great then zero ");
                        }
                        else
                        {
                            ProductNames.Add(userInputProductName);
                            priceProducts.Add(userInputProductPrice);
                            Console.WriteLine("product and price succesfily add");
                        }
                        break;

                    case 3:
                        Console.WriteLine("please enter your item to i search that for you : ");
                        string search = Console.ReadLine().Trim().ToLower();
                     
                        if (ProductNames.Contains(search))
                        {
                            int index = ProductNames.IndexOf(search);
                            Console.WriteLine($"name product: {ProductNames[index]} the price is {priceProducts[index]}");
                        }
                        else
                        {
                            Console.WriteLine("not found");
                        }
                        break;

                    case 4:
                        int holePrice(List<int> Price)
                        {
                            return Price.Sum();
                        }

                        Console.WriteLine(holePrice(priceProducts)+"$");
                        break;

                    default:
                        Console.WriteLine("please enter a nuber betwinn 1 to 5");
                        break;
                }

                Console.WriteLine("\n==========================================");
                Console.WriteLine("Please choose an option:");
                Console.WriteLine("1. Show all products");
                Console.WriteLine("2. Add new product");
                Console.WriteLine("3. Search product");
                Console.WriteLine("4. Calculate total warehouse value");
                Console.WriteLine("5. Exit");
                Console.WriteLine("==========================================");
                Console.Write("Enter your choice (1-5): ");
                userInput = int.Parse(Console.ReadLine());
            }

           
            Console.WriteLine("goodbye");
        }
    }
}
