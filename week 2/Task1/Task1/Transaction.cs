using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Transaction
    {
        public int TransactionId;
        public int Amount;
        public string ProductName;
        public string DateTime;
        public Transaction()
        {
        }
        public Transaction(Transaction t) 
        {
            TransactionId = t.TransactionId;
            Amount = t.Amount;
            ProductName = t.ProductName;
            DateTime = t.DateTime;
        }
        public void printtrasantion(Transaction t)
        {
            Console.WriteLine(t.TransactionId);
            Console.WriteLine(t.Amount);
            Console.WriteLine(t.ProductName);
            Console.WriteLine(t.DateTime);
        }
    }
}
