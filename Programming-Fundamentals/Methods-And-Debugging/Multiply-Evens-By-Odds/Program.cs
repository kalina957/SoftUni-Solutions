using System;

namespace Multiply_Evens_By_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMultipleOfEvensAndOdds(num));
        }
        static int GetMultipleOfEvensAndOdds(int num)
        {
            int sumEvens  = GetSumOfEvenDigits(num) ;
            int sumOdds = GetSumOfOddDigits(num);
            int result = sumEvens * sumOdds;
            return result;
        }
        static int GetSumOfOddDigits(int num)
        {
            int sum = 0;
            int length = Math.Abs(num).ToString().Length;
            for (int i = 0; i <= length ; i++)
            {
                int lastDigit = num % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }
                num /= 10;
            }
            return sum;
        }
        static int GetSumOfEvenDigits(int num)
        {
            int sum = 0;
            int length = Math.Abs(num).ToString().Length;
            for (int i = 1; i <= length; i++)
            {
                int lastDigit = num % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                num /= 10;
            }
            return sum;
        }
    }
}
