using System;
using System.Linq;

namespace Problem_4._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] parameters = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = parameters[0];
            int cols = parameters[1];
            int[,] matrix = new int[rows,cols];

            for (int r = 0; r < rows; r++)
            {
                int[] row = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int c = 0; c < cols; c++)
                {
                    matrix[r, c] = row[c];
                }
            }
            int maxSum = 0;
            int currSum = 0;

            for (int r = 0; r < matrix.GetLength(0)-2; r++)
            {
                for (int c = 0; c < matrix.GetLength(1) - 2; c++)
                {

                }
            }
        }
    }
}
