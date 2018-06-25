using System;
using System.Globalization;

namespace Day_Of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.ParseExact(Console.ReadLine(),"d-M-yyyy", CultureInfo.InvariantCulture) ;
           var day = date.DayOfWeek;
            Console.WriteLine(day);
        }
    }
}
