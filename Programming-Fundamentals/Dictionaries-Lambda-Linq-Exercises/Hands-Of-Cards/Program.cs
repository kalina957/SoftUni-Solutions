using System;
using System.Collections.Generic;
using System.Linq;

namespace Hands_Of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> currPoints = new Dictionary<string, int>();
            string[] cardPower = {"0" , "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
            string[] cardType = { "A","C","D","H","S"};
            char[] delimiters = new char[] { ',',':' };
            List<string> input = Console.ReadLine().Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToList();
            Dictionary<string,List<string>> values = new Dictionary<string, List<string>>();
            
            while (input[0]!="JOKER")
            {
                int result = 0;
                int a = 0;
                int b = 0;
                for (int i = 1; i < input.Count; i++)
                {

                    if (input[i].Length == 4)
                    {
                        a = 10;
                        b = Array.IndexOf(cardType, (input[i].Substring(3, 1)));
                    }
                    else
                    {
                        a = Array.IndexOf(cardPower, (input[i].Substring(1, 1)));
                        b = Array.IndexOf(cardType, (input[i].Substring(2, 1)));
                    }
                    result = a * b;

                    if (!values.ContainsKey(input[0]))
                    {
                        values.Add(input[0], new List<string> { input[i] });
                    }
                    else
                    {
                        if (!values[input[0]].Contains(input[i]))
                            values[input[0]].Add(input[i]);
                        else result = 0;
                    }

                    if (currPoints.ContainsKey(input[0]))
                    {
                        currPoints[input[0]] += result;
                    }
                    else
                    {
                        currPoints.Add(input[0], result);
                    }
                }
                 input = Console.ReadLine().Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToList();
            }
            foreach (var person in currPoints)
            {
                Console.WriteLine(person.Key+": "+person.Value);
            }
        }
    }
}
