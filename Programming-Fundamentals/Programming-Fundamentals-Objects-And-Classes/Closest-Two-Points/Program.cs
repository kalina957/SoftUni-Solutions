using System;
using System.Collections.Generic;
using System.Linq;

namespace Closest_Two_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string point1 = string.Empty;
            string point2 = string.Empty;
            double len = double.MaxValue;
            List<int> coordinates = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
                Point point = new Point { x = nums[0], y = nums[1] };

                for (int j = 0; j < coordinates.Count; j+=2)
                {
                    int side1 = point.x-coordinates[j];
                    int side2 = point.y-coordinates[j+1];
                    double difference =Math.Sqrt(side1*side1+side2*side2);

                    if (difference<len)
                    {
                        point1 =$"{coordinates[j]}, {coordinates[j+1]}";
                        point2 = $"{point.x}, {point.y}";
                        len = difference;
                    }
                }
                coordinates.Add(point.x);
                coordinates.Add(point.y);
            }

            Console.WriteLine($"{len:f3}");
            Console.WriteLine($"({point1})");
            Console.WriteLine($"({point2})");
           
        }

        class Point
        {
            public int x { get; set; }
            public int y { get; set; }
        }
    }
}
