using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class ATM
    {
        public int balance;
        public int ammount;
        public List<string> transactions = new List<string>();
        public ATM() 
        { 
            balance = 1000;
            transactions.Add($"Balance: {balance}");
        }
        public void deposit(int ammount)
        {
            balance += ammount;
            transactions.Add($"deposite: {ammount} , balance: {balance}");
        }
        public void withdraw(int ammount)
        {
            if (balance >= ammount)
            {
                balance -= ammount;
                transactions.Add($"withdraw: {ammount} , balance: {balance}");
            }
            else
            {
                Console.WriteLine("Not enough balance!");
            }
        }
        public int check_Balance() 
        { 
            return balance;
        }
        public void history()
        {
            Console.WriteLine("Transaction History:");
            foreach (string transaction in transactions)
            {
                Console.WriteLine(transaction);
            }
        }

    }
}
