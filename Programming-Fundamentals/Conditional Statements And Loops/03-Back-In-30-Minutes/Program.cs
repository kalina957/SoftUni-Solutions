using System;

namespace Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());


            if (minutes + 30 < 60) Console.WriteLine($"{hours}:{minutes + 30:d2}");
            else
            { if (hours == 23 && minutes + 30 > 59)
                {
                    hours = 0;
                    Console.WriteLine($"{hours }:{minutes + 30 - 60:d2}");
                }

                else Console.WriteLine($"{hours + 1}:{minutes + 30 - 60:d2}");

            }

        }
    }
}
