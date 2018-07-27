using System;
using System.Collections.Generic;
using System.Linq;

namespace Reverse_Numbers_with_a_Stack
{
    class ReversedNums
    {
       public static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>();

            foreach (var num in numbers)
            {
                stack.Push(num);
            }

            Console.WriteLine(string.Join(" ",stack));
        }
    }
}
