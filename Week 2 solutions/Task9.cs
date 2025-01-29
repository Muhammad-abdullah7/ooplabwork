using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value;
            float area, length;
            Console.WriteLine("Enter the length: ");
            value = Console.ReadLine();
            length=float.Parse(value);
            area = length * length;
            Console.WriteLine("The area is: ");
            Console.WriteLine(area);
            Console.ReadKey();



        }
    }
}
