using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static List<Student> students = new List<Student>();

        static void Main(string[] args)
        {
            string name;
            int option, id = -1, matricmarks, intermarks, ecatmarks, i = 1;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Show Students");
                Console.WriteLine("3. Calculate Aggregate");
                Console.WriteLine("4. Top Students");
                Console.WriteLine("Select an option (1-4): ");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter name: ");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter matric marks: ");
                        matricmarks = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter inter marks: ");
                        intermarks = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter ecat marks: ");
                        ecatmarks = int.Parse(Console.ReadLine());
                        Student s1 = new Student(id, name, matricmarks, intermarks, ecatmarks);
                        do
                        {
                            if (s1.Id == -1)
                            {
                                s1.Id = i;
                                i++;
                                break;
                            }
                        }
                        while (true);
                        students.Add(s1);
                        Console.WriteLine("Student added successfully!");
                        Console.ReadLine();
                        break;
                    case 2:
                        foreach (var student in students)
                        {
                            student.ShowStudents();
                        }
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Enter student ID: ");
                        id = int.Parse(Console.ReadLine());
                        Student studentToCalculate = students.FirstOrDefault(s => s.Id == id);
                        if (studentToCalculate != null)
                        {
                            Console.WriteLine($"Aggregate: {studentToCalculate.CalculateAggregate()}");
                        }
                        else
                        {
                            Console.WriteLine("Student not found.");
                        }
                        Console.ReadLine();
                        break;
                    case 4:
                        var topStudents = students.OrderByDescending(s => s.CalculateAggregate()).Take(3);
                        foreach (var student in topStudents)
                        {
                            student.ShowStudents();
                        }
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}