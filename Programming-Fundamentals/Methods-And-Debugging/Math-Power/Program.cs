using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double numPowered = CalculatePower(num,power);
            Console.WriteLine(numPowered);
        }
        static double CalculatePower(double num,double power)
        {
            double newValue = Math.Pow(num, power);
            return newValue;
        }
    }
}
