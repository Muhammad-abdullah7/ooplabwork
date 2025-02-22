using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    public class User
    {
        public string Name { get; set; }
        public string Cnic { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public User(string name, string cnic, string password, string role)
        {
            Name = name;
            Cnic = cnic;
            Password = password;
            Role = role;
            WriteUser(name, cnic, password, role);

        }
        public User() { }
        internal static void Login()
        {
            throw new NotImplementedException();
        }
        public void WriteUser(string name, string cnic, string password, string role)
        {
            StreamWriter sw = new StreamWriter("Users.txt", true);
            sw.WriteLine(name + "," + cnic + "," + password + "," + role);
            sw.Flush();
            sw.Close();
        }
        public void ReadUser()
        {
            StreamReader sr = new StreamReader("Users.txt");
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] user = line.Split(',');
                Console.WriteLine("Name: " + user[0]);
                Console.WriteLine("CNIC: " + user[1]);
                Console.WriteLine("Password: " + user[2]);
                Console.WriteLine("Role: " + user[3]);
            }
            sr.Close();
        }
    }
}
