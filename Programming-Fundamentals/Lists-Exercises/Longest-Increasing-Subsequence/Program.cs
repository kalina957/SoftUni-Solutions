using System;
using System.Collections.Generic;
using System.Linq;

namespace Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> len = new List<int>();
            for (int i = 0; i < nums.Length; i++) { len.Add(0); }
            List<int> bestList = new List<int>();
            int[] prev = new int[nums.Length];
            int left = -1;


            for (int p = 0; p < nums.Length; p++)
            {
                if(p>0) { left = len.IndexOf(len.Where(x => x < nums[3]).First());
                }
                if (len.Contains(left)) len[p] = 1 + len[left];
                else len[p] = 1;
                prev[p] = left;

            }
        }
    }
}
