using System;
using System.Linq;

namespace Distance_Between_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = GetPoint(Console.ReadLine());
            Point point2 = GetPoint(Console.ReadLine());
            double distance = CalcDistance(point1,point2);
            Console.WriteLine($"{distance:f3}");
        }

        private static Point GetPoint(string input)
        {
            int[] coordinates = input.Split().Select(int.Parse).ToArray();
            return new Point() {x = coordinates[0], y = coordinates[1] }; 
        }

        private static double CalcDistance(Point p1, Point p2)
        {
            double x = p1.x - p2.x;
            double y = p1.y - p2.y;
            double result = Math.Sqrt(x*x+y*y);
            return result;
        }
        
    }
    class Point
    {
        public double x { get; set; }
        public double y { get; set; }
    }
}
