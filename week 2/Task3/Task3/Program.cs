using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ATM acc1 = new ATM();
            acc1.deposit(999);
            acc1.deposit(5000);
            acc1.withdraw(15000);
            //acc1.history();
        }
    }
}
