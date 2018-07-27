using System;
using System.Collections.Generic;

namespace _5._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] childrenArray = Console.ReadLine().Split();
            int turns = int.Parse(Console.ReadLine());
            Queue<string> children = new Queue<string>(childrenArray);
            int counter = 1;

            int length = children.Count;

            while (length!=1)
            {
                string currChild = children.Dequeue();
                if (counter%turns==0)
                {
                    Console.WriteLine($"Removed {currChild}");
                    length--;
                }
                else
                {
                    children.Enqueue(currChild);
                }
                counter++;
            }
            Console.WriteLine($"Last is {children.Dequeue()}");
        }
    }
}
