using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Group_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.None)
                .Select(int.Parse)
                .ToArray();
            int[] sizes = new int[3];

            foreach (var number in input)
            {
                sizes[Math.Abs(number % 3) ]++;
            }

            int[][] jaggedArr = new int[3][];

            for (int counter = 0; counter < sizes.Length; counter++)
            {
                jaggedArr[counter] = new int[sizes[counter]];
            }

            int[] index = new int[3];

            foreach (var num in input)
            {
                int remainder = Math.Abs(num%3);
                jaggedArr[remainder][index[remainder]] = num;
                index[remainder]++;
            }

            for (int rows = 0; rows < jaggedArr.Length; rows++)
            {
                for (int cols = 0; cols < jaggedArr[rows].Length; cols++)
                {
                    Console.Write(jaggedArr[rows][cols]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
