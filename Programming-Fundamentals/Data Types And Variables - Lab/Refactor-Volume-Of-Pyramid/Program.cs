﻿using System;

namespace Refactor_Volume_Of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Length: ");
           double lenght = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
          double  Height = double.Parse(Console.ReadLine());
           double V = (lenght*width*Height) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", V);
        }
    }
}
