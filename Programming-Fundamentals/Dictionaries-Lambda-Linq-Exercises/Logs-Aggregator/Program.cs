using System;
using System.Collections.Generic;
using System.Linq;

namespace Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedDictionary<string, SortedDictionary<string, int>> userLogs = new SortedDictionary<string, SortedDictionary<string, int>>();


            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string ip = input[0];
                string userName = input[1];
                int duration = int.Parse(input[2]);

                InsertUser(userLogs,userName);
                InsertIPAndDuration(userLogs,userName,ip,duration);
            }

            PrintData(userLogs);
        }

        private static void PrintData(SortedDictionary<string, SortedDictionary<string, int>> userLogs)
        {
            foreach (var input in userLogs)
            {
                string userName = input.Key;
                int duration = input.Value.Values.Sum();
                List<string> ip = input.Value.Keys.ToList();
                Console.WriteLine("{0}: {1} [{2}]" , userName,duration, String.Join(", ",ip));
            }
        }

        private static void InsertIPAndDuration(SortedDictionary<string, SortedDictionary<string, int>> userLogs, string userName, string ip, int duration)
        {
            if (!userLogs[userName].ContainsKey(ip))
            {
                userLogs[userName].Add(ip,0);
            }
            userLogs[userName][ip] += duration;
        }

        private static void InsertUser(SortedDictionary<string, SortedDictionary<string, int>> userLogs ,string userName)
        {
            if (!userLogs.ContainsKey(userName))
            {
                userLogs.Add(userName, new SortedDictionary<string, int>());
            };
        }
    }
}
