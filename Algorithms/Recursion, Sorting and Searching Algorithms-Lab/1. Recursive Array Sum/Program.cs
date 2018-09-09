using System;
using System.Linq;

namespace _1._Recursive_Array_Sum
{
    class Program
    {
        static int PrintSum(int[] nums,int index)
        {
            if (index == nums.Length)
            {
                return 0;
            }
            return nums[index] + PrintSum(nums,index+1);

        }

        static void Main(string[] args)
        {

            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int result = PrintSum(nums, 0 );
            Console.WriteLine(result);
        }
    }
}
