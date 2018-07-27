using System;
using System.Collections.Generic;

namespace _3._Decimal_to_Binary_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> binaryNum = new Stack<int>();
            int num = int.Parse(Console.ReadLine());

            if (num==0)
            {
                Console.WriteLine("0");
                Environment.Exit(0);
            }
            while (num/2!=0)
            {
                int remainder = num % 2;
                num /= 2;
                binaryNum.Push(remainder);
            }
            binaryNum.Push(1);
            Console.WriteLine(string.Join("",binaryNum));
        }
    }
}
