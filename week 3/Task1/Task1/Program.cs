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
            // default constructor
            clockType empty_time = new clockType();
            Console.Write("Empty time: ");
            empty_time.printTime();
            // Parameterized constructor (one parameter)
            clockType hour_time = new clockType(8);
            Console.Write("Hour time: ");
            hour_time.printTime();
            // Parameterized constructor (two parameters)
            clockType minute_time = new clockType(8, 10);
            Console.Write("Minute time: ");
            minute_time.printTime();
            // Parameterized constructor (three parameters)
            clockType full_time = new clockType(8, 10, 10);
            Console.Write("Full time: ");
            full_time.printTime();
            // increment second
            full_time.incrementSecond();
            Console.Write("Full time (Increment Second): ");
            full_time.printTime();
            // increment hours
            full_time.incrementhours();
            Console.Write("Full time (Increment hours): ");
            full_time.printTime();
            // increment mintues
            full_time.incrementminutes();
            Console.Write("Full time (Increment Mintues): ");
            full_time.printTime();
            //Elasped time
            DateTime starttime = new DateTime();
            DateTime endtime = DateTime.Now;
            TimeSpan elapsedtime = endtime - starttime;
            Console.WriteLine("Elapsed Time: " + elapsedtime.ToString(@"hh\:mm\:ss"));
            //Remaining time
            DateTime endOfDay = DateTime.Today.AddDays(1).AddTicks(-1);
            TimeSpan remainingTime = endOfDay - endtime;
            Console.WriteLine("Remaining Time: " + remainingTime.ToString(@"hh\:mm\:ss"));
            // chcek if equal
            bool flag = full_time.isEqual(9, 11, 11);
            Console.WriteLine("Flag: " + flag);
            // chcek if equal with object
            clockType cmp = new clockType(10, 12, 1);
            flag = full_time.isEqual(cmp);
            Console.WriteLine("Object Flag: " + flag);
        }
    }
}
