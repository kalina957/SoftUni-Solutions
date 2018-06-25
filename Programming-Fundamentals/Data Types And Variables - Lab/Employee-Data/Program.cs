using System;

namespace Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            long iD = long.Parse(Console.ReadLine());
            int employeeNum = int.Parse(Console.ReadLine());

            Console.WriteLine($"First name: {firstName}\nLast name: {lastName}\nAge: {age}\nGender: {gender}\nPersonal ID: {iD}\nUnique Employee number: {employeeNum}");
        }
    }
}
