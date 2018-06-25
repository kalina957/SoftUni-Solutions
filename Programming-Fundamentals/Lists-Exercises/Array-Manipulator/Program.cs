using System;
using System.Collections.Generic;
using System.Linq;

namespace Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < nums.Count; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                if (input[0] == "print") break;

                switch (input[0])
                {
                    case "add": nums.Insert(Convert.ToInt32(input[1]), Convert.ToInt32(input[2])); break;
                    case "addMany":
                        for (int j = input.Length-1 ; j >=2; j--)
                        {
                            nums.Insert(Convert.ToInt32(input[1]), Convert.ToInt32(input[j]));
                        }
                        break;

                    case "contains":
                        if (nums.Contains(Convert.ToInt32(input[1])) == true)
                        {
                            Console.WriteLine(nums.IndexOf(Convert.ToInt32(input[1])));
                        }
                        else Console.WriteLine(-1);
                        break;

                    case "remove": nums.RemoveAt(Convert.ToInt32(input[1])); break;

                    case "shift":
                        for (int k = 0; k < Convert.ToInt32(input[1]); k++)
                        {
                            int first = nums[0] ;
                            nums.RemoveAt(0);
                            nums.Insert(nums.Count, first);
                        } break;

                    case "sumPairs":
                        int length =nums.Count/2 ;
                        {
                            for (int j = 0; j < length; j++)
                            {
                                nums[j] = nums[j] + nums[j + 1];
                                nums.RemoveAt(j+1);
                            }
                        }
                        break;
                }
            }
            Console.WriteLine("["+String.Join(", " ,nums)+"]");
        }
    }
}
