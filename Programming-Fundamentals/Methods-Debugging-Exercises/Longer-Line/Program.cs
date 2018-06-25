using System;

namespace Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double line1 = GetDistanceBetweenTwoPoints(x1, y1, x2, y2);
            double line2 = GetDistanceBetweenTwoPoints(x3, y3, x4, y4);

            double firstDistaceToZero = GetDistanceToZero(x1, y1);
            double secDistanceToZero = GetDistanceToZero(x2, y2);
            double thirdDistaceToZero = GetDistanceToZero(x3, y3);
            double fourthDistanceToZero = GetDistanceToZero(x4, y4);


            if (line1>=line2)
            {

                if (firstDistaceToZero < secDistanceToZero)
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                  
                }
            }
            else
            {

                if (thirdDistaceToZero > fourthDistanceToZero)
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
                else
                {

                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
            }

        }
    
        private static double GetDistanceToZero(double x, double y )
        {
            double distance = Math.Sqrt(x * x + y * y);
            return distance;
        }
        private static double GetDistanceBetweenTwoPoints(double x1, double y1, double x2, double y2)
        {
            double lineLength = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return lineLength;
        }
    }
}
