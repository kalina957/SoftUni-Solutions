using System;
using System.Linq;

namespace _2._Square_With_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] parameters = Console.ReadLine().Split(new string[] { ", " },StringSplitOptions.None).Select(int.Parse).ToArray();
            int rows = parameters[0];
            int cols = parameters[1];
            int[,] matrix = new int[rows, cols];

            for (int r = 0; r < rows; r++)
            {
                int[] values = Console.ReadLine().Split(new string[] { ", "}, StringSplitOptions.None).Select(int.Parse).ToArray();
                for (int c = 0; c < cols; c++)
                {
                    matrix[r, c] = values[c];
                }
            }

            int maxSum = 0;
            int X = 0;
            int Y = 0;
            int Z = 0;
            int T = 0;

            for (int r = 0; r < rows-1; r++)
            {
                for (int c = 0; c < cols-1; c++)
                {
                    int currSum = 0;
                    int x = matrix[r,c];
                    int y = matrix[r, c + 1];
                    int z = matrix[r + 1, c];
                    int t = matrix[r + 1, c + 1];
                    currSum = x + y + z + t;

                    if (currSum>maxSum)
                    {
                        maxSum = currSum;
                        X = x;
                        Y = y;
                        Z = z;
                        T = t;
                    }
                }
            }
            Console.WriteLine(X + " " + Y);
            Console.WriteLine(Z + " " + T);
            Console.WriteLine(maxSum);
        }
    }
}
