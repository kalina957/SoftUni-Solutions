using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Student_Groups
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Group> groups = new List<Group>();
            int counter = 0;
            int seatCounter = 0;
            string inputLine = string.Empty;
            string studentsDataString = string.Empty;
            while (true)
            {
                if (counter == 0)
                {
                    inputLine = Console.ReadLine();
                }
                else
                {
                    counter = 0;
                }
                if (inputLine == "End")
                {
                    break;
                }

                string[] input = inputLine.Split(new[] { " => " },StringSplitOptions.RemoveEmptyEntries);
                string town = input[0];
                int seats = int.Parse(input[1].Substring(0, 1));
                List<Student> currStudentsList = new List<Student>();
                while (true)
                {
                    if (counter == 0)
                    {
                        studentsDataString = Console.ReadLine();
                    }
                    string[] studentData = studentsDataString.Split('|').Select(x => x.Trim()).ToArray();
                    if (studentData.Length != 3)
                    {
                        counter = 1;
                        seatCounter = 0;
                        inputLine = studentsDataString;
                        if (currStudentsList.Count > 0)
                        {
                            Group currGroup = new Group { town = town, students = new List<Student>() };
                            foreach (var st in currStudentsList)
                            {
                                currGroup.students.Add(st);
                            }
                            groups.Add(currGroup);
                            currStudentsList.Clear();
                        }

                        break;
                    }
                    Student student = new Student { Name = studentData[0], Email = studentData[1], Date = DateTime.ParseExact(studentData[2], "d-MMM-yyyy", CultureInfo.InvariantCulture) };
                    currStudentsList.Add(student);
                    seatCounter++;
                    if (seatCounter % seats == 0)
                    {
                        Group currGroup = new Group { town = town, students = new List<Student>() };
                        foreach (var st in currStudentsList)
                        {
                            currGroup.students.Add(st);
                        }
                        groups.Add(currGroup);
                        currStudentsList.Clear();
                    }

                    counter = 0;
                }
            }

            Console.WriteLine($"Created {groups.Count} groups in {groups.Select(x => x.town).Distinct().Count()} towns:");
            foreach (var group in groups)
            {
                Console.Write($"{group.town} => ");
                int i = 0;
                foreach (var st in group.students)
                {
                    if (i == 0)
                    {
                        Console.Write(st.Email);
                    }
                    else
                    {
                        Console.Write(", " + st.Email);
                    }
                    i++;
                }
                Console.WriteLine();
            }
        }
    }
    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
    }
    class Town
    {
        public string Name { get; set; }
        public int seats { get; set; }
        public List<Student> students { get; set; }
    }
    class Group
    {
        public string town { get; set; }
        public List<Student> students { get; set; }
    }
}
