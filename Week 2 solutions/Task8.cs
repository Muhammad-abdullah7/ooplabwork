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
            String value;
            Console.WriteLine("Enter a floating value: ");
            float num=float.Parse(Console.ReadLine());
            Console.WriteLine("You have inputted : ");
            Console.WriteLine(num);
            Console.ReadKey();
        }
    }
}
