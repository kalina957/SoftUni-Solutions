﻿using System;

namespace Comparing_Floats
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double difference = (Math.Abs(num1-num2));

            if (difference >= 0.000001) Console.WriteLine("False");
            else Console.WriteLine("True");


        }
    }
}
