using System;

namespace Integer_To_Hex_And_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string numInBinary = Convert.ToString(number, 2);
            string hexValue = number.ToString("X");
            Console.WriteLine(number.ToString(hexValue));
            Console.WriteLine(numInBinary);
           
        }
    }
}
