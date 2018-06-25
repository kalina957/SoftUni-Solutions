using System;
using System.Collections.Generic;
using System.Linq;

namespace Fold_And_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = nums.Length / 4;
            var left = nums.Take(k).Reverse();
            var right = nums.Reverse().Take(k);
            int[] row1 = left.Concat(right).ToArray();
            int[] row2 = nums.Skip(k).Take(2*k).ToArray();
            var sum = row1.Select((x, index) => x + row2[index]);
            Console.WriteLine(String.Join(" ",sum));
            
        }
    }
}
