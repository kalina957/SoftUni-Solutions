using System;
using System.Linq;

namespace Most_Frequent_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int num = 0;
            int len = 0;
            int bestLen = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                len = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] == nums[i])len++ ;
                }
                if (len > bestLen)
                {
                    bestLen = len;
                    num = nums[i] ;
                }
            }
            Console.WriteLine(num);
            
        }
    }
}
