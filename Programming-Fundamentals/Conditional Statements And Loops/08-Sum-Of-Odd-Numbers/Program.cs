using System;

namespace Sum_Of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 1; i <=n*2; i+=2)
            {
                Console.WriteLine(i);
                counter += i;
            }
            Console.WriteLine($"Sum: {counter}");
        }
    }
}
