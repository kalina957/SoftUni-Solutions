using System;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> expressionsIndexes = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                int ch = input[i];

                if (ch=='(')
                {
                    expressionsIndexes.Push(i);
                }
                else if (ch==')')
                {
                    int prevIndex = expressionsIndexes.Pop();
                    int currCharIndex = i;
                    Console.WriteLine(input.Substring(prevIndex,currCharIndex-prevIndex+1));
                }
            }
        }
    }
}
