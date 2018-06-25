using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var events = new SortedDictionary<DateTime, string>();

            events[new DateTime(1998, 3, 8)] = "Kalina's birth date";
            events[new DateTime(2013, 11, 5)] = "SoftUni's birth date";
            events[new DateTime(1975, 4, 4)] = "Microsoft's birth date";
            events[new DateTime(2004, 2, 4)] = "Facebook's birth date";
            events[new DateTime(2013, 11, 5)] = "SoftUni was founded";

            foreach (var entry in events)
            {
                Console.WriteLine("{0:dd-MMM-yyyy}: {1}",entry.Key, entry.Value);
            }
            List<int> elements = new List<int>() { 10, 20, 31, 40 };
            // ... Find index of first odd element.
            var oddIndex = elements.Where((x => x % 2 != 0));
            Console.WriteLine(oddIndex);
        }
    }
}
