using System;

namespace Primes_In_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
           int a= int.Parse(Console.ReadLine());
           int b = int.Parse(Console.ReadLine());
            bool isPrime = true;
            int counter = 0;

            if (b-a <= 0)
            {
                Console.WriteLine();
                return;
            }
                int[] nums = new int[b - a + 1];

            for (int i = a,k=0; i <= b; i++,k++)
            {
                isPrime = true;
                nums[k] = i;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if ( i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    else isPrime=true;
                }
                if ( isPrime == true) counter++;

                if (i == 1 || i == 0) isPrime = false;
                else if (isPrime && counter == 1) Console.Write(i);
                else if(isPrime)Console.Write(", "+i);
            }
            Console.WriteLine();
        }
    }
}
