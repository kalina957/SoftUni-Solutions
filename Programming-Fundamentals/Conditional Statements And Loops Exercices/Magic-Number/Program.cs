using System;

namespace Magic_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbolOne = char.Parse(Console.ReadLine().ToLower());
            char symbolTwo = char.Parse(Console.ReadLine().ToLower());
            char symbolThree = char.Parse(Console.ReadLine().ToLower());

            for (int i = symbolOne; i <= symbolTwo; i++)
            {
                for (int j = symbolOne; j <= symbolTwo; j++)
                {
                    for (int k = symbolOne; k <= symbolTwo; k++)
                    {
                        if (i!=symbolThree && j!=symbolThree && k!=symbolThree) Console.Write($"{(char)i}{(char)j}{(char)k} ");
                    }
                }
            }


        }
    }
}
