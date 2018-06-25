using System;
using System.Linq;

namespace zadachka
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int left = nums.Where(x => x < nums[5]).First();
            Console.WriteLine(left);
        }
    }
}
