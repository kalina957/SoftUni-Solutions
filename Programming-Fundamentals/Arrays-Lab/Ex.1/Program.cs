using System;
using System.Linq;

namespace SumArrays
{
    class Program
    {
        static void Main()
        {
            int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = Math.Max(arr1.Length, arr2.Length);
            int[] biggerArray = new int[sum];

            for (int i = 0; i < biggerArray.Length; i++)
            {
                sum = (arr1[i % arr1.Length] + arr2[i % arr2.Length]);
                Console.Write(sum + " ");
            }
            Console.WriteLine();

        }
    }
}