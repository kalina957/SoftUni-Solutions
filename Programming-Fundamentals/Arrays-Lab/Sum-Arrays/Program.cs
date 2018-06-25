using System;
using System.Linq;

namespace Ex._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int length = Math.Max(arr1.Length, arr2.Length);
            int sum = 0;
            int[] arr3 = new int[length];
            sum = 0;


            if (arr1.Length < length)
            {
                for (int i = 0, f = i; i < length; i++, f++)
                {
                    if (sum == length) break;
                    if (i == arr1.Length) i = 0;
                    arr3[f] = arr1[i] + arr2[f];
                    Console.Write(arr3[f] + " ");
                    sum++;
                }
            }
            else if (arr2.Length < length)
            {
                for (int i = 0, f = i; i < length; i++, f++)
                {
                    if (sum == length) break;
                    if (i == arr2.Length) i = 0;
                    arr3[f] = arr1[f] + arr2[i];
                    Console.Write(arr3[f] + " ");
                    sum++;
                }
            }
            else
            {
                for (int i = 0; i < length; i++)
                {
                    arr3[i] = arr1[i] + arr2[i];
                    Console.Write(arr3[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
