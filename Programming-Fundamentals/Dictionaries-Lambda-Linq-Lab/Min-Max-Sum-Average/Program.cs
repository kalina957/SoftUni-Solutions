using System;
using System.Linq;

namespace Min_Max_Sum_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[] nums = new int[input];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Sum = "+ nums.Sum());
            Console.WriteLine("Min = " + nums.Min());
            Console.WriteLine("Max = " + nums.Max());
            Console.WriteLine("Average = " + nums.Average());
        }
    }
}
