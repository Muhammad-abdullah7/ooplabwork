using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transaction t1 = new Transaction();
            t1.TransactionId = 1;
            t1.Amount = 1000;
            t1.ProductName = "Product1";
            t1.DateTime = "2025/02/01 10:07:25 AM";
            Transaction t2 = new Transaction(t1);
            Console.WriteLine("Before edit First Object");
            t1.printtrasantion(t1);
            Console.WriteLine("Before edit Second Object");
            t2.printtrasantion(t2);
            t1.TransactionId = 2;
            t1.Amount = 5000;
            t2.TransactionId = 2;
            t2.Amount = 9000;
            Console.WriteLine("After edit First Object");
            t1.printtrasantion(t1);
            Console.WriteLine("After edit Second Object");
            t2.printtrasantion(t2);




        }
    }
}
