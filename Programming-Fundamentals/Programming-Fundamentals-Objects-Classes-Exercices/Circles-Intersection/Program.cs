using System;
using System.Linq;

namespace Circles_Intersection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] circle1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] circle2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var c1 = new Circle { Center = new Point { x=circle1[0], y=circle1[1]} ,Radius = circle1[2] };
            var p1 = new Point { x = circle1[0], y = circle1[1] };
            var c2 = new Circle { Center = new Point{ x=circle2[0], y = circle2[1]}, Radius = circle2[2] };
            var p2 = new Point { x = circle2[0], y = circle2[1] };
            double distance = GetDistance(p1, p2);

            if (distance<=c1.Radius+c2.Radius)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        private static double GetDistance(Point p1, Point p2)
        {
            double dist = Math.Sqrt((p1.x-p2.x)* (p1.x - p2.x)+ (p1.y - p2.y) * (p1.y - p2.y));
            return dist;
        }

        class Circle
        {
            public Point Center { get; set; }
            public int Radius { get; set; }
        }
        class Point
        {
            public int x { get; set; }
            public int y { get; set; }

        }
    }
}
