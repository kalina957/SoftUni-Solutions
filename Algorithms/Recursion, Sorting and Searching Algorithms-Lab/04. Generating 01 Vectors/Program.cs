using System;

namespace _04._Generating_01_Vectors
{
    class Program
    {
        private static void Gen01(int[] vector, int index)
        {
            if (index == vector.Length)
            {
                Console.WriteLine(String.Join("", vector));
                return;
            } 

            for (int i = 0; i <= 4; i++)
            {
                vector[index] = i;
                Gen01(vector, index + 1);
            }
        }

        static void Main(string[] args)
        {
            int bits = int.Parse(Console.ReadLine());
            int[] vector = new int[bits];
            Gen01(vector, 0);
        }
    }
}
