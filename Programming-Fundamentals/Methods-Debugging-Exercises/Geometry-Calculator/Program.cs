using System;

namespace Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            if (figure=="triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine($"{GetTriangleArea(a,b):f2}");  
            }
            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine($"{GetSquareArea(a):f2}");
            }
            if (figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine($"{GetRectangleArea(a,b):f2}");
            }
            if (figure == "circle")
            {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine($"{GetCircleArea(a):f2}");
            }
        }
        static double GetTriangleArea(double a, double b)
        {
            double area = a * b / 2;
            return area;
        }
        static double GetSquareArea(double a)
        {
            double area = a * a;
            return area;
        }
        static double GetRectangleArea(double a,double b)
        {
            double area = a * b;
            return area;
        }
        static double GetCircleArea(double r)
        {
            double area = Math.PI * r * r;
            return area;
        }
    }
}
