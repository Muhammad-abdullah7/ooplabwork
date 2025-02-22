using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static List<Products> List = new List<Products>();
        static void Main(string[] args)
        {
            int option, id, price;
            string name, category, brandname, country;
            int worth;
            while (true)
            { 
                Console.Clear();
                Console.WriteLine("1.Add Product.");
                Console.WriteLine("2.Show Products.");
                Console.WriteLine("3.Total store worth.");
                Console.WriteLine("Choose your option(1-3): ");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter Product Id: ");
                        id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Product Name: ");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter Product Price: ");
                        price = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Product Category: ");
                        category = Console.ReadLine();
                        Console.WriteLine("Enter Product BrandName: ");
                        brandname = Console.ReadLine();
                        Console.WriteLine("Enter Product Country: ");
                        country = Console.ReadLine();
                        List.Add(new Products(id, name, price, category, brandname, country));
                        break;
                    case 2:
                        //Products.ShowProducts();
                        foreach (var prod in List)
                        {
                            Console.WriteLine(prod);
                        }
                        break;
                    case 3:
                        worth = 0;
                        foreach (var prod in List)
                        {
                            worth += prod.Price;
                        }
                        Console.WriteLine($"Total store worth: {worth}");
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
