using System;
using System.Collections.Generic;
using System.Linq;

namespace Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            double sum = 0;

            for (int i = 0; i < nums.Count; i++)
            {
                
                double result = 0;
                int length = (nums[i].ToString()).Length - 1;
                for (double j = length; j >= 0; j--)
                {
                    double n = nums[i] % 10;
                    result += n * (Math.Pow(10, j));
                    nums[i] = nums[i] / 10;
                }
                sum +=result;
            }
            Console.WriteLine(sum);
        }
    }
}
