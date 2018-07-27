using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Recursive_Fibonacci
{
    public class Program
    {

        public static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            long[]  memo = new long[n+1];
            long result = getFibonacci(n,memo);
            Console.WriteLine(result);
        }

        private static long getFibonacci(long n,long[] memo)
        {
            if (n<=2)
            {
                return 1;
            }
            if (memo[n] == 0)
            {
                memo[n] = getFibonacci(n - 1,memo) + getFibonacci(n - 2,memo);
            }

            return memo[n];
        }
    }
}
