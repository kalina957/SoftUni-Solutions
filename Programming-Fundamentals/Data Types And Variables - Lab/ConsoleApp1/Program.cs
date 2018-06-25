using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int n = Convert.ToInt32(num, 16);
            Console.WriteLine(n);
        }
    }
}
