using System;

namespace _Debit_Card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int creditCardNumOne = int.Parse(Console.ReadLine());
            int creditCardNumTwo = int.Parse(Console.ReadLine());
            int creditCardNumThree = int.Parse(Console.ReadLine());
            int creditCardNumFour = int.Parse(Console.ReadLine());
            Console.Write($"{creditCardNumOne:D4} ");
            Console.Write($"{creditCardNumTwo:D4} ");
            Console.Write($"{creditCardNumThree:D4} ");
            Console.Write($"{creditCardNumFour:D4}");
        }
    }
}