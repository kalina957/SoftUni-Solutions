using System;
using System.Numerics;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            BigInteger factorial = GetFactorial(num);
            Console.WriteLine(GetTrailingZeroes(factorial));
        }
        static BigInteger GetFactorial(int num)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
        static int GetTrailingZeroes(BigInteger factorial)
        {
            int zeroes=0;
            BigInteger digit = 0;
            while (true)
            {
                digit = factorial % 10;
                if (digit == 0) zeroes += 1;
                if (digit != 0) break ;
                factorial /= 10;
            }
            return zeroes;
        }
    }
}
