using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();
            SortedDictionary<double, double> dict = new SortedDictionary<double, double>();

            foreach (double entry in nums)
            {
                if (dict.ContainsKey(entry)) dict[entry]++;
                else dict[entry] = 1;
            }
            foreach (var num in dict.Keys)
            {
                Console.WriteLine(num+" -> "+dict[num]);
            }
        }
    }
}
