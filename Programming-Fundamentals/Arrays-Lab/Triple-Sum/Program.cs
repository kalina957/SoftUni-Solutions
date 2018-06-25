using System;
using System.Linq;

namespace Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
           long[] nums = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long counter = 0;
        
          for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    for (int l = 0; l < nums.Length; l++)
                    {
                        if (nums[i] + nums[j] == nums[l])
                        {
                            Console.WriteLine($"{nums[i]} + {nums[j]} == {nums[l]}");
                            counter++;
                            break;
                        }
                    }  
                }
            }
            if (counter == 0) Console.WriteLine("No");
        }
    }
}
