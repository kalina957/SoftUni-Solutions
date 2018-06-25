using System;

namespace Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            int sum = 0;
            int digits = 1;

            for (int num = 1; num <= counter; num++)
            {
                sum = 0;
                digits = num;
                while (digits>0)
                { 
                    sum += digits % 10;
                    digits = digits / 10;
                   
                }

                bool isSpecial = sum == 5 || sum == 7 || sum == 11;
                if (isSpecial) Console.WriteLine($"{num} -> {isSpecial}");
                else Console.WriteLine($"{num} -> {isSpecial}");
            }
        }
    }
}
