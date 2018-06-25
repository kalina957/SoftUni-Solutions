using System;

namespace Sieve_Of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long max = Math.Max(9 * n + 1, n * n + 1);
            bool[] primes = new bool[max];

            for (long i = 0; i <= n; i++) primes[i] = true;

            for (long num = 2; num <= n; num++)
            {
                if (primes[num] == true)
                {
                    for (int multiplier = 2; multiplier*num <= n; multiplier++)
                    {
                        primes[multiplier*num]= false;
                    }
                }
                if (primes[num] == true) Console.Write(num + " ");
            }
           
        }
    }
}
