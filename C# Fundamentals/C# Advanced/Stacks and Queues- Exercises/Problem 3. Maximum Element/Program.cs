using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3._Maximum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            Stack<int> maxStack = new Stack<int>();

            for (int i = 0; i < num; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                switch (input[0])
                {
                    case 1:
                        int element = input[1];
                        if (maxStack.Count == 0 || maxStack.Peek() < element)
                        {
                            maxStack.Push(element);
                        }
                        stack.Push(element);
                        break;

                    case 2: int elementToRemove = stack.Pop();
                        if (maxStack.Peek() == elementToRemove)
                        {
                            maxStack.Pop();
                        }

                        break;

                    default:
                        int elementToPrint = maxStack.Peek();
                        Console.WriteLine(elementToPrint);
                        break;
                }

            }
        }
    }
}
