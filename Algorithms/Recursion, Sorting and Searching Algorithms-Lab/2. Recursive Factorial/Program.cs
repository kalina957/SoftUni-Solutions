using System;

namespace _2._Recursive_Factorial
{
    class Program
    {
        static int Factorial(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            return num* Factorial(num-1);
        }
        static void Main(string[] args)

        {
            int num = int.Parse(Console.ReadLine());
            int result = Factorial(num);
            Console.WriteLine(result);
        }
    }
}
