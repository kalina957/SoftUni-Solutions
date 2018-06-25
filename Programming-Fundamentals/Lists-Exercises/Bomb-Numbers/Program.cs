using System;
using System.Collections.Generic;
using System.Linq;

namespace Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == arr[0])
                {
                    int position = i - arr[1];
                    if (position < 0) position = 0;
                    for (int j = 0; j < 1 + 2 * arr[1]; j++)
                    {
                        nums.RemoveAt(position);
                        if (nums.Count == position) break;
                    }
                    i--;
                }
            }
            Console.WriteLine(nums.Sum());
        }
    }
}
