using System;

namespace Ex._1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNumbers(1,100);
        }
        static void PrintNumbers(int start, int end )
        {
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine($"{i} ");
            }
        }
    }
}
