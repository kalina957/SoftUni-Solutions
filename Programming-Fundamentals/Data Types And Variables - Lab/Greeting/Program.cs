﻿using System;

namespace Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
             string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Hallo, {firstName} {lastName}.\nYou are {age} years old.");
        }
    }
}
