using System;

namespace Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            int sum = 0;
            int number = 1;
           

            for (int i = 1; i <= counter; i++)
            {
                sum = 0;
                number = i;
                while (number> 0)
                {
                    sum += number % 10;
                    number = number / 10;
                }


              bool  isSpecial = sum == 5 || sum == 7 || sum == 11;
                if (isSpecial) Console.WriteLine($"{i} -> {isSpecial}");
                else Console.WriteLine($"{i} -> {isSpecial}");



            }
        }
    }
}
