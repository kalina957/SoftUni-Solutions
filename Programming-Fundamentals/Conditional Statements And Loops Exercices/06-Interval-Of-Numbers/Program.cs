using System;

namespace Interval_Of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());


            if (num2 > num1)
            {
                for (int i = num1; i <= num2; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = num2; i <= num1; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
