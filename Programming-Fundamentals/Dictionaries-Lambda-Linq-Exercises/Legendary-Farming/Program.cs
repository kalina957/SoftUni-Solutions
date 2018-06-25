using System;
using System.Collections.Generic;
using System.Linq;

namespace Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> legendaries = new Dictionary<string, long>();
            Dictionary<string, long> junks = new Dictionary<string, long>();
            legendaries["shards"] = 0;
            legendaries["fragments"] = 0;
            legendaries["motes"] = 0;
            bool getMaterial = true;
            string win = "";

            while (getMaterial)
            {
                List<string> input = Console.ReadLine().Split(' ').ToList();
                for (int i = 0; i < input.Count; i += 2)
                {
                   string itemType = input[i + 1].ToLower();
                    long itemValue = long.Parse(input[i]);

                    if (legendaries.ContainsKey(itemType))
                    {
                        legendaries[itemType] += itemValue;
                        if (legendaries[itemType] >= 250)
                        {
                            win = itemType;
                            legendaries[itemType] -= 250;
                            getMaterial = false;
                            break;
                        }
                    }
                    else
                    {
                        if (!junks.ContainsKey(itemType))
                        {
                            junks[itemType] = 0;
                        }
                        junks[itemType] += itemValue;
                    }
                }
            }

                legendaries = legendaries
             .OrderBy(x => x.Key)
             .OrderByDescending(x => x.Value)
             .ToDictionary(x => x.Key, y => y.Value);

                junks = junks
             .OrderBy(x => x.Key)
             .ToDictionary(x => x.Key, y => y.Value);

            string price = GetPrice(win);
            Console.WriteLine($"{price} obtained!");

                foreach (var item in legendaries)
                {
                    Console.WriteLine("{0}: {1}",item.Key,item.Value);
                }
                foreach (var item in junks)
                {
                    Console.WriteLine("{0}: {1}", item.Key, item.Value);
                }
        }

        private static string GetPrice(string win)
        {
            switch (win)
            {
                case "motes": return "Dragonwrath"; break;
                case "fragments": return "Valanyr"; break;
                case "shards": return "Shadowmourne"; break;
                default:return "h" ;break;
            }
        }

      
    }
}
