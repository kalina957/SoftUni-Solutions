using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            string part = Console.ReadLine();
            switch (part)
            {
                case "face": Console.WriteLine($"{GetCubeFaceDiagonal(a):f2}"); break;
                case "space": Console.WriteLine($"{GetCubeSpaceDiagonal(a):f2}"); break;
                case "volume": Console.WriteLine($"{GetCubeVolume(a):f2}"); break;
                case "area": Console.WriteLine($"{GetCubeSurfaceArea(a):f2}"); break;
            }
        }
        static double GetCubeFaceDiagonal(double a)
        {
            double faceDiagonal = Math.Sqrt(2 * a * a);
            return faceDiagonal;
        }
        static double GetCubeSpaceDiagonal(double a)
        {
            double spaceDiagonal =Math.Sqrt( 3*a*a );
            return spaceDiagonal;
        }
        static double GetCubeVolume(double a)
        {
            double volume = Math.Pow(a,3);
            return volume;
        }
        static double GetCubeSurfaceArea(double a)
        {
            double area = 6 * a * a;
            return area;
        }
    }
}
