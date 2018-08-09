using System;
using System.Linq;

namespace Problem_2._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n,n];

            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < n; i++)
            {
                int[] row = Console.ReadLine().Split(new string[]{ " "},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = row[j];

                }
            }

            for (int i = 0; i < n; i++)
            {
                sum1 += matrix[i, i];
                sum2 += matrix[n - i -1, i];
            }
            int result = Math.Abs(sum1-sum2);
            Console.WriteLine(result);
        }
    }
}
