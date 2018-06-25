using System;
using System.Linq;

namespace Extract_Middle_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int length = nums.Length;

            if (length==1)
            {
                Console.WriteLine(nums[0]);
            }
            else if (length%2==0)
            {
                Console.WriteLine("{ "+ nums[length / 2 - 1]+", " + nums[length / 2] +" }");
            }
            else 
            {
                Console.WriteLine("{ " + nums[length / 2 - 1]+", " + nums[length / 2] +", "+ nums[length / 2 + 1] + " }");
            }
        }
    }
}
