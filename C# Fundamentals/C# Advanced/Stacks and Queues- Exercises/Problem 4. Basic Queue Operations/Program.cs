using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_4._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] operations = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] elementsToAdd = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int elementsToAddCount = operations[0];
            int elementsToRemove = operations[1];
            int searchedElement = operations[2];
            Queue<int> numbers = new Queue<int>();

            for (int i = 0; i < elementsToAddCount; i++)
            {
                int elementToAdd = elementsToAdd[i];
                numbers.Enqueue(elementToAdd);
            }

            for (int i = 0; i < elementsToRemove; i++)
            {
                numbers.Dequeue();
            }
            if (numbers.Contains(searchedElement))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (numbers.Count>0)
                {
                    Console.WriteLine(numbers.Min());
                }
                else
                {
                    Console.WriteLine("0");
                }
                
            }
        }
    }
}
