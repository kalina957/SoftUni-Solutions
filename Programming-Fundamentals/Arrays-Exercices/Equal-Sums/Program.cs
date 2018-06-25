using System;
using System.Linq;

namespace Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sum1 = 0;
            int sum2 = 0;
            int index = 0;
            int counter = 0;

            if (nums.Length == 1)
            {
                Console.WriteLine("0"); return;
            }

            for (int i = -1; i < nums.Length; i++)
            {
                if (i >= 0) sum1 += nums[i];
                else sum1 = 0;
                sum2 = 0;
                if (i == nums.Length - 2 && sum1 == 0) index =nums.Length-1;

                for (int j = i+2; j <nums.Length ; j++)
                {
                    sum2 +=nums[j];
                    if (sum1 == sum2)
                    {
                        index =i+1;
                        counter++;
                    }
                }
                
            }
            if (index==0 && counter==0) Console.WriteLine("no") ;
            else Console.WriteLine(index);
        }
    }
}
