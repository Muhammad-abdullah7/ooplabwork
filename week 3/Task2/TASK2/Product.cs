using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK2
{
    public class Product
    {
        public string Name;
        public string Category;
        public int Price;
        public int Quantity;
        public int MinimumQuantity;
        public static List<Product> Products = new List<Product>();

        public Product() { }
        public Product(string Name, string Category, int Price, int Quantity, int MinimumQuantity)
        {
            this.Name = Name;
            this.Category = Category;
            this.Price = Price;
            this.Quantity = Quantity;
            this.MinimumQuantity = MinimumQuantity;
            Products.Add(this);
        }
        public static Product FindProductWithHighestUnitPrice()
        {
            Product HighestUnitPriceProduct = Products[0];
            foreach (Product p in Products)
            {
                if (p.Price > HighestUnitPriceProduct.Price)
                {
                    HighestUnitPriceProduct = p;
                }
            }
            return HighestUnitPriceProduct;
        }
        public double CalculateSalesTax(string Category)
        {
            if(Category == "Grocery")
            {
                return Price * 0.1;
            }
            else if (Category == "Fruit")
            {
                return Price * 0.05;
            }
            else
            {
                return Price * 0.15;
            }
        }
        public override string ToString()
        {
            return "Name: " + Name + "\nCategory: " + Category + "\nPrice: " + Price + "\nQuantity: " + Quantity + "\nMinimum Quantity: " + MinimumQuantity + "\n=========================";
        }

    }
}
