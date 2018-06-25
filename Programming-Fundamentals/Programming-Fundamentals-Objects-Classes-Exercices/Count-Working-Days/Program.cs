using System;
using System.Globalization;
using System.Linq;

namespace Count_Working_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            var startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
          
            int workingDays = 0;

            DateTime[] holidays = new DateTime[11];

            holidays[0] = new DateTime(2012, 01, 01);
            holidays[1] = new DateTime(2012, 03, 03);
            holidays[2] = new DateTime(2012, 05, 01);
            holidays[3] = new DateTime(2012, 05, 06);
            holidays[4] = new DateTime(2012, 05, 24);
            holidays[5] = new DateTime(2012, 09, 06);
            holidays[6] = new DateTime(2012, 09, 22);
            holidays[7] = new DateTime(2012, 11, 01);
            holidays[8] = new DateTime(2012, 12, 24);
            holidays[9] = new DateTime(2012, 12, 25);
            holidays[10] = new DateTime(2012, 12, 26);

            for (var currDate = startDate; currDate <= endDate; currDate = currDate.AddDays(1))
            {
                var day = currDate.DayOfWeek;

                DateTime temp = new DateTime(2012, currDate.Month, currDate.Day);

                if (!day.Equals(DayOfWeek.Sunday) && !day.Equals(DayOfWeek.Saturday) && !holidays.Contains(temp))
                {
                    workingDays++;
                }
            }
            Console.WriteLine(workingDays);

        }
    }
}
