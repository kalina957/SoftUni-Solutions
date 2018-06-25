using System;

namespace Day_Of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = { "Monday", "Tuesday" , "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int day = int.Parse(Console.ReadLine());
            if (day > 0 && day <= 7) Console.WriteLine(daysOfWeek[day - 1]);
            else Console.WriteLine("Invalid Day!");
        }
    }
}
