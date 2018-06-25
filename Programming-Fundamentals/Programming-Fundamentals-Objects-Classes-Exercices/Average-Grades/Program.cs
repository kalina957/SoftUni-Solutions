using System;
using System.Collections.Generic;
using System.Linq;

namespace Average_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                Student student = new Student
                {
                    Name = input[0],
                    Grades = input.Skip(1).Select(double.Parse).ToList(),
                    AverageGrade = input.Skip(1).Select(double.Parse).Sum() / (input.Length - 1)
                };
                students.Add(student);
            }
            foreach (var student in students.Where(x => x.AverageGrade >= 5).OrderBy(x => x.Name).ThenByDescending(x => x.AverageGrade))
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:f2}");
            }
        }

        class Student
        {
            public string Name { get; set; }
            public List<double> Grades = new List<double>();
            public double AverageGrade { get; set; }
        }
    }
}
