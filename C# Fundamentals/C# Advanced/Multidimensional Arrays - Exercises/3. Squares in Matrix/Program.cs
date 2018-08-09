using System;
using System.Linq;

namespace _3._Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] parameters = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = parameters[0];
            int cols = parameters[1];
            string[,] matrix = new string[rows,cols];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] row = Console.ReadLine().Split();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = row[j];
                }
            }

            bool isSquare = true;
            int squares = 0;

            for (int i = 0; i < matrix.GetLength(0)-1; i++)
            {
                
                for (int j = 0; j < matrix.GetLength(1)-1; j++)
                {
                    string firstChar = matrix[i, j];
                    if (matrix[i,j+1]!=firstChar || matrix[i+1,j]!=firstChar || matrix[i+1,j+1]!=firstChar)
                    {
                        isSquare = false;
                    }
                    else
                    {
                        isSquare = true;
                    }
                    if (isSquare)
                    {
                        squares++;
                    }

                }
            }
            Console.WriteLine(squares);
        }
    }
}
