using System;
using System.Linq;

class FibonacciNumbers
{
    static void Main()
    {
       
        long n = long.Parse(Console.ReadLine());
        Console.WriteLine(GetFibonacciNumber(n));
        
        }
    static long GetFibonacciNumber(long n)
    {
        long firstNum = 0;
        long secondNum = 1;
        long thirdNum = 1;

        if (n == 1 || n == 0)
        {
            thirdNum = 1;
        }
        else
        {

            for (int i = 0; i < n - 1; i++)
            {
                firstNum = secondNum;
                secondNum = thirdNum;
                thirdNum = firstNum + secondNum;
            }
        }
        return thirdNum;
    }
}