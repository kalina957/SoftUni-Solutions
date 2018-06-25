using System;
using System.Linq;

namespace Fold_And_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = nums.Length / 4;
            int[] arrBegin = new int[k];
            int[] arrEnd = new int[nums.Length];
            int[] sum = new int[nums.Length/2];

            for (int i = 0, j = nums.Length - 1; i < nums.Length; i++,j--)
            {
                arrBegin[i] = nums[i];
                arrEnd[i] = nums[j];
                if (i == k - 1) break;
            }
            for (int i = 0, j=k ; i < nums.Length/2; i++,j++)
            {
                sum[i] = nums[j];
            }
            Array.Reverse(arrBegin);
            for (int i = 0,j=0; j < nums.Length/2 ; i++,j++)
            { 
                sum[j] = arrBegin[i]+sum[j];
                if (i == k - 1) arrBegin = arrEnd;
                Console.Write($"{sum[j]} ");
                if (i == k - 1) i = -1;
            }
        }
    }
}
