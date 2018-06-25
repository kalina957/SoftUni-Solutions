using System;

namespace Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Before:\na = {num1}\nb = {num2}");

            Console.WriteLine($"After:\na = {num2}\nb = {num1}");
        }
    }
}
