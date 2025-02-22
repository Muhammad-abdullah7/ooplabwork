using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int MainMenuOption;
            string ProductName = "", ProductCategory = "";
            int ProductPrice = 0, ProductQuantity = 0, ProductMinimumQuantity = 0;
            while(true) {
                Console.Clear();
                MainMenuOption = MainMenu();
                switch (MainMenuOption)
                {
                    case 1:
                        Console.Clear();
                        AddProduct(ref ProductName, ref ProductCategory, ref ProductPrice, ref ProductQuantity, ref ProductMinimumQuantity);
                        Product product = new Product(ProductName, ProductCategory, ProductPrice, ProductQuantity, ProductMinimumQuantity);
                        break;
                    case 2:
                        Console.Clear();
                        foreach (Product p in Product.Products)
                        {
                            Console.WriteLine(p);
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine(Product.FindProductWithHighestUnitPrice());
                        break;
                    case 4:
                        Console.Clear();
                        foreach (Product p in Product.Products)
                        {
                            Console.WriteLine("Product: " + p.Name + " \nSales Tax: " + p.CalculateSalesTax(ProductCategory));
                            Console.WriteLine("====================");
                        }
                        break;
                    case 5:
                        Console.Clear();
                        foreach (Product p in Product.Products)
                        {
                            if (p.Quantity < p.MinimumQuantity)
                            {
                                Console.WriteLine(p);
                            }
                        }
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            }
        }
        public static int MainMenu()
        {
            int Option;
            Console.WriteLine("===== DEPARTMENTAL STORE SOFTWARE SYSTEM =====");
            Console.WriteLine("1.Add Product");
            Console.WriteLine("2.View All Products");
            Console.WriteLine("3.Find Product with the Highest Unit Price");
            Console.WriteLine("4.View Sales Tax of All Products");
            Console.WriteLine("5.Products to be Ordered. (less than the threshold)");
            Console.WriteLine("6.Exit");
            Console.WriteLine("Select your choice: ");
            Option = Convert.ToInt32(Console.ReadLine());
            return Option;
        }
        public static void AddProduct(ref string ProductName, ref string ProductCategory, ref int ProductPrice, ref int ProductQuantity, ref int ProductMinimumQuantity)
        {
            Console.WriteLine("Enter product name: ");
            ProductName = Console.ReadLine();
            Console.WriteLine("Enter product category(Grocery, Fruit or any other):");
            ProductCategory = Console.ReadLine();
            Console.WriteLine("Enter the price of product: ");
            ProductPrice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter product quantity: ");
            ProductQuantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter minimun quantity for the product: ");
            ProductMinimumQuantity = Convert.ToInt32(Console.ReadLine());
        }

    }
}
