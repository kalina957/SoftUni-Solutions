using System;
using System.Linq;

namespace Condense_Array_To_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] condensed = new int[nums.Length-1];
            int i = 0;
            int end = condensed.Length;

            if (nums.Length == 1) Console.WriteLine(nums[0]);
            else
            {
                while (end >= 0)
                {
                    for (i = 0; i < end; i++)
                    {
                        condensed[i] = nums[i] + nums[i + 1];
                    }
                    nums = condensed;
                    end--;
                }
                Console.WriteLine(condensed[i]);
            }
        }
    }
}
