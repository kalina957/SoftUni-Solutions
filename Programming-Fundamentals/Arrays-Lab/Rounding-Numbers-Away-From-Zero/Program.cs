using System;
using System.Linq;

namespace Rounding_Numbers_Away_From_Zero
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i] +" => "+ Math.Round(nums[i],0,MidpointRounding.AwayFromZero));
            }
        }
    }
}
