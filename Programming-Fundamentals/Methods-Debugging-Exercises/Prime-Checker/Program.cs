using System;
using System.Collections.Generic;

namespace Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
                Console.WriteLine(CheckIfPrime(n));
        }
        static bool CheckIfPrime(long n )
        {
            bool isPrime = false;
            if (n == 0|| n==1) isPrime = false;
            if (n == 2|| n==3) isPrime = true;
            for (long i = 2; i <= Math.Sqrt(n); i++)
            { 
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
                else isPrime = true;
            }
            return isPrime;
        }
       
    }
}
