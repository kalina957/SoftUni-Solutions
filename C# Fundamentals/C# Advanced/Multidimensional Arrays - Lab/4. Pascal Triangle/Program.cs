using System;

namespace _4._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            long[][] jaggedArray = new long[rows][];

            for (int i = 0; i < rows; i++)
            {
                 jaggedArray[i] = new long[i+1];
                jaggedArray[i][0] = 1;
                jaggedArray[i][i] = 1;
            }

            for (int i = 2; i < jaggedArray.Length; i++)
            {
                for (int j = 1; j < jaggedArray[i].Length - 1; j++)
                {
                    jaggedArray[i][j] = jaggedArray[i - 1][j - 1] + jaggedArray[i - 1][j];
                }
            }

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine(string.Join(" ", jaggedArray[i]));
            }
        }
    }
}
