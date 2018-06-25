using System;
using System.Collections.Generic;
using System.Linq;

namespace Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] words = Console.ReadLine()
                .ToLower()
                .Split(new char[] { ' ', '.', ',', ':', ';' , '(' ,')','[', ']','!','?','"','/','\\','\'' },StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .ToArray();

            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (var word in words)
            {
               dict.Add(word, word.Length);
            }

            var result = dict.Keys.Where(x=>x.Length<5).OrderBy(x=>x);
            Console.WriteLine(string.Join(", ",result));
        }
    }
}
