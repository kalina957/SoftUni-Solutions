using System;

namespace Rectangle_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            double parameter = 2 * (width + lenght);
            double area = 1.0 * width * lenght;
            double diagonal = Math.Sqrt(width * width + lenght * lenght);
            Console.WriteLine($"{parameter}\n{area}\n{diagonal}");
        }
    }
}
