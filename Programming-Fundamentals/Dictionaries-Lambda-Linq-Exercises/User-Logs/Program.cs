using System;
using System.Collections.Generic;
using System.Linq;

namespace User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {

            SortedDictionary<string, Dictionary<string, int>> dict = new SortedDictionary<string, Dictionary<string, int>>();
            string[] input = Console.ReadLine().Split().ToArray();
            if (input[0] == "end") return;
            string user = input[2].Substring(5, input[2].Length - 5);
            string IP = input[0].Substring(3, input[0].Length - 3);
            int count = 1;
            while (input[0] != "end")
            {


                if (!dict.ContainsKey(user))
                {
                    dict.Add(user, new Dictionary<string, int> { { IP, count } });
                }
                else
                {
                    if (dict[user].ContainsKey(IP))
                    {
                        dict[user][IP] += count;
                    }
                    else
                    {
                        dict[user].Add(IP, 1);
                    }
                }
                input = Console.ReadLine().Split().ToArray();
                if (input[0] == "end") break;
                user = input[2].Substring(5, input[2].Length - 5);
                IP = input[0].Substring(3, input[0].Length - 3);
                count = 1;
            }
            foreach (var person in dict.Keys)
            {
                Console.WriteLine(person + ": ");
                var last = dict[person].Last();

                foreach (var item in dict[person])
                {
                    if (item.Equals(last)) Console.WriteLine($"{item.Key} => {item.Value}.");
                    else Console.Write($"{item.Key} => {item.Value}, ");
                }

            }
        }
    }
}
