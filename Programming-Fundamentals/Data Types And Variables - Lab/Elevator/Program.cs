﻿using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            double rides = Math.Ceiling((1.0*people/capacity));

            Console.WriteLine(rides);
        }
    }
}
