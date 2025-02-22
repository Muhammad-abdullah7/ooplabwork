using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator c1 = new Calculator();
            Console.WriteLine(c1.add(25, 5));
            Console.WriteLine(c1.subtract(25, 5));
            Console.WriteLine(c1.multiply(25, 5));
            Console.WriteLine(c1.divide(25, 5));
        }
    }
}
