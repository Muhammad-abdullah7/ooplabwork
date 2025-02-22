using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Category { get; set; }
        public string BrandName { get; set; }
        public string Country { get; set; }
        public Products(int id, string name, int price,string category, string brandname, string country)
        {
            Id = id;
            Name = name;
            Price = price;
            Category = category;
            BrandName = brandname;
            Country = country;
        }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Price: {Price}, Category: {Category}, BrandName: {BrandName}, Country: {Country} ";
        }
    }
}
