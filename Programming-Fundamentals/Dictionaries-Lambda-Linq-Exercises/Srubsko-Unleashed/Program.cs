using System;
using System.Collections.Generic;
using System.Linq;

namespace Srubsko_Unleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> dict = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                if (!input.Contains(" @"))
                {
                    continue;
                }
                string singer = input.Substring(0, input.IndexOf(" @"));
                string[] placeAndIncome = input.Substring(input.IndexOf("@") + 1).Split();

                if (placeAndIncome.Length < 3)
                {
                    continue;
                }

                if (singer.Split().Length > 3)
                {
                    continue;
                }
                string venue = string.Empty;
                for (int i = 0; i < placeAndIncome.Length - 2; i++)
                {
                    venue += placeAndIncome[i];
                    venue += " ";
                }
                venue = venue.TrimEnd();
                if (venue.Split().Length > 3)
                {
                    continue;
                }

                int tickets = 0;
                bool ticketExists = Int32.TryParse(placeAndIncome[placeAndIncome.Length - 2], out tickets);
                int count = 0;
                bool countExists = Int32.TryParse(placeAndIncome[placeAndIncome.Length - 1], out count);

                if (!ticketExists || !countExists)
                {
                    continue;
                }

                if (!dict.ContainsKey(venue))
                {
                    dict[venue] = new Dictionary<string, int>();
                }
                if (!dict[venue].ContainsKey(singer))
                {
                    dict[venue][singer] = 0;
                }
                dict[venue][singer] += tickets * count;
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}");
                foreach (var data in dict[item.Key].OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {data.Key} -> {data.Value}");
                }
            }
        }
    }
}
