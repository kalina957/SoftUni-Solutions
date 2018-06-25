using System;

namespace Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double ha = double.Parse(Console.ReadLine());
            double area = GetTriangleArea(a,ha);
            Console.WriteLine(area);
        }
        static double GetTriangleArea(double a, double ha)
        {
            double area = a * ha / 2;
            return area;
        }
    }
}
