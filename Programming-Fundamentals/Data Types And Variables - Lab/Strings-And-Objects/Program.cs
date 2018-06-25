using System;

namespace Strings_And_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = Console.ReadLine();
            string world = Console.ReadLine();
            object greeting = hello +" "+ world;
            Console.WriteLine((string)greeting);

        }
    }
}
