using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Mentor_Group
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            while (true)
            {
                string inputLine = Console.ReadLine();
                if (inputLine=="end of dates")
                {
                    break;
                }
                string[] input = inputLine.Split(new char[] { ' ', ',' }, StringSplitOptions.None);
                string name = input[0];
                Student student = new Student { Name = name, Comments = new List<string>(), Dates = new List<DateTime>() };

                
                for (int i = 1; i <= input.Length-1; i++)
                {
                    DateTime date = DateTime.ParseExact(input[i], "dd/MM/yyyy",CultureInfo.InvariantCulture);
                    if (students.Any(x => x.Name == name))
                    {
                        students.First(x => x.Name == name).Dates.Add(date);
                    }
                    else
                    {
                        student.Dates.Add(date);
                    }
                    
                }
                if (!students.Any(x => x.Name == name))
                {
                    students.Add(student);
                }
                
            }
            while (true)
            {
                string inputLine = Console.ReadLine();
                if (inputLine == "end of comments")
                {
                    break;
                }
                string[] input = inputLine.Split('-');
                string name = input[0];
                string comment = input[1];
                if (students.Any(x=>x.Name==name))
                {
                    students.First(x => x.Name == name).Comments.Add(comment);
                }
               
            }
            foreach (var student in students.OrderBy(x=>x.Name))
            {
                Console.WriteLine(student.Name);
                Console.WriteLine("Comments:");
                foreach (var comment in student.Comments)
                {
                    Console.WriteLine($"- {comment}");
                }
                Console.WriteLine("Dates attended:");
                foreach (var date in student.Dates.OrderBy(x=>x))
                {
                    Console.WriteLine($"-- {date.Date.ToString("dd/MM/yyyy")}");
                }
            }
        }
    }
    class Student
    {
        public string Name { get; set; }
        public List<string> Comments { get; set; }
        public List<DateTime> Dates { get; set; }
    }
}
