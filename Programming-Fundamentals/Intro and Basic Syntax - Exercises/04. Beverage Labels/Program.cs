using System;

namespace _04._Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();
            int productVolume = int.Parse(Console.ReadLine());
            int energyPer100Ml = int.Parse(Console.ReadLine());
            int sugarPer100Ml = int.Parse(Console.ReadLine());
            Console.WriteLine($"{productVolume}ml {productName}:");
            Console.WriteLine($"{(double)productVolume * energyPer100Ml / 100}kcal, {((double)productVolume * sugarPer100Ml / 100)}g sugars");
        }
    }
}
