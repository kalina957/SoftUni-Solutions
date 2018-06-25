using System;
using System.Linq;

namespace Pairs_By_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int diff = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[i] - nums[j] == diff || nums[j] - nums[i] == diff) counter++ ;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
