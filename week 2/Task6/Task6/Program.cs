using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {
        List<User> users = new List<User>();
        static void Main(string[] args)
        {
            int option, id=0, i=-1;
            string name, cnic, password;
            while (true) {

                Console.WriteLine("Press 1 to Register");
                Console.WriteLine("Press 2 to Login");
                Console.WriteLine("Press 3 to Exit");
                option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        Console.WriteLine("Enter your name: ");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter your CNIC: ");
                        cnic = Console.ReadLine();
                        Console.WriteLine("Enter your password: ");
                        password = Console.ReadLine();
                        id++;
                        User user1 = new User(, name, cnic, password);
                        break;
                    case 2:
                        User.Login();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
        }
    }
}
