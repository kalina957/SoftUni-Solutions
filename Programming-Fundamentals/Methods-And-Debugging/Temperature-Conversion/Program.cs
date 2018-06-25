using System;

namespace Temperature_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = double.Parse(Console.ReadLine());
            double celcius = FromFahrenheitToCelcius(fahrenheit);
            Console.WriteLine($"{celcius:f2}");
        }
        static double FromFahrenheitToCelcius(double fahrenheit)
        {
            return (fahrenheit-32)*5 / 9;
        }
    }
}
