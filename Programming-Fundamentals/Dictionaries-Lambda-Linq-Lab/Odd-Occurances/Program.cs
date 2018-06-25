using System;
using System.Collections.Generic;
using System.Linq;

namespace Odd_Occurances
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().ToLower().Split().ToArray();
            Dictionary<string, int> dict = new Dictionary<string, int>();

            
            foreach (var word in words) 
            {
                if(dict.ContainsKey(word)) dict[word]++; 
                else dict[word] = 1;
            }
            List<string> results = new List<string>();
            foreach (var word in dict)
            {
                if (word.Value % 2 != 0) results.Add(word.Key) ;
            }
            Console.WriteLine(string.Join(", ",results));
        }
    }
}
