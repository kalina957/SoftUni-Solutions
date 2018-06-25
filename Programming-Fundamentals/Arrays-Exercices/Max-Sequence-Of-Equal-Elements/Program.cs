using System;
using System.Linq;

namespace Max_Sequence_Of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int len = 1;
            int start = 0;
            int bestStart = 0;
            int bestLen = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    len++;
                    if ( len > bestLen)
                    {
                         bestStart = start;
                         bestLen = len;
                    }
                    
                }
                else
                {
                    start = i;
                    len = 1;
                }
            }
            for (int i = bestStart; i <bestStart+bestLen ; i++)
            {
                Console.Write(nums[i]+" ");
            } 
        }
    }
}
