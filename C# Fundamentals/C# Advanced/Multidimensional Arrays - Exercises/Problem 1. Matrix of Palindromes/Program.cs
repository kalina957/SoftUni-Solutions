using System;
using System.Linq;

namespace Problem_1._Matrix_of_Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] parameters = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = parameters[0];
            int cols = parameters[1];
            int[,] matrix = new int[rows,cols];
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray(); 

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    char middleLetter = alphabet[i+j];
                    char sideLetters = alphabet[i];
                    Console.Write($"{sideLetters}{middleLetter}{sideLetters} ");
                }
                Console.WriteLine();
            }
        }
    }
}
