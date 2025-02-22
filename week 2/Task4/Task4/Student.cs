using System;

namespace Task4
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MatricMarks { get; set; }
        public int InterMarks { get; set; }
        public int EcatMarks { get; set; }

        public Student() { }

        public Student(int id, string name, int matricMarks, int interMarks, int ecatMarks)
        {
            Id = id;
            Name = name;
            MatricMarks = matricMarks;
            InterMarks = interMarks;
            EcatMarks = ecatMarks;
        }

        public void ShowStudents()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Matric Marks: {MatricMarks}, Inter Marks: {InterMarks}, Ecat Marks: {EcatMarks}");
        }

        public double CalculateAggregate()
        {
            return (((MatricMarks * 0.1) + (InterMarks * 0.4) + (EcatMarks * 0.5)) * 100) / 750;
        }
    }
}