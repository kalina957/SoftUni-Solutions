using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Stack_Operations
{
    class Program
    {
       public static void Main(string[] args)
        {
            int[] operations = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int elementsToPush = operations[0];
            int elementsToPop = operations[1];
            int[] numbersArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> numbers = new Stack<int>();


            for (int i = 0; i < numbersArray.Length; i++)
            {
                numbers.Push(numbersArray[i]);
            }
            for (int i = 0; i < elementsToPop; i++)
            {
                numbers.Pop();
            }
            int searchedNum = operations[2];
            bool numIsPresent = numbers.Contains(searchedNum); 

            if (numIsPresent)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(string.Join("",numbers.ToArray().OrderBy(x=>x).Take(1)));
            }
        }
    }
}
