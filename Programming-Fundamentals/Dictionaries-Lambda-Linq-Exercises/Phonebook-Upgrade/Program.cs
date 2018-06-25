﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            while (input[0] != "END")
            {
                switch (input[0])
                {
                    case "A":
                        if (phonebook.ContainsKey(input[1]))
                        {
                            phonebook[input[1]] = input[2];
                        }
                        else
                        {
                            phonebook.Add(input[1], input[2]);
                        }
                        break;
                }
                input = Console.ReadLine().Split().ToArray();
            }
        }
    }
}
