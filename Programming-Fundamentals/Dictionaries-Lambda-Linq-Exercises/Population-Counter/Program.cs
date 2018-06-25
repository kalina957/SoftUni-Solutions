using System;
using System.Collections.Generic;
using System.Linq;

namespace Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> dict = new Dictionary<string, Dictionary<string, long>>();
            string[] input = Console.ReadLine().Split('|');

            while (input[0]!="report")
            {
                if (!dict.ContainsKey(input[1]))
                    dict.Add(input[1],new Dictionary<string, long> {{ input[0], Convert.ToInt32(input[2])}});
                else
                {
                    dict[input[1]].Add(input[0], Convert.ToInt32(input[2]));
                }

                 input = Console.ReadLine().Split('|');
            }
            

            foreach (var item in dict.OrderByDescending(x => x.Value.Sum(y => y.Value)))
            {
                List<long> sumOfTowns = item.Value.Select(x => x.Value).ToList();
                Console.WriteLine($"{item.Key} (total population: {sumOfTowns.Sum()})");
                Console.Write($"=>{string.Join("=>", item.Value.OrderByDescending(x => x.Value).Select(x => $"{x.Key}: {x.Value}\r\n").OrderByDescending(x => x))}");

            }
        }
    }
}
