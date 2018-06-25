using System;
using System.Linq;

namespace Rotate_And_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] sum = new int[nums.Length];
            int rotations = int.Parse(Console.ReadLine());
            int length = nums.Length;
            int v = 1;

            for (int r = 1; r <= rotations; r++)
            {
                int[] reversed = new int[nums.Length];
                for (int i = 0; i <= length - 1; i++)
                {
                    reversed[(i + v) % length] = nums[i];
                    sum[(i + v) % length] += reversed[(i + v) % length];
                    if (i == length - 1) break;
                }
                nums = reversed;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"{sum[i]} ");
            }
        }
    }
}