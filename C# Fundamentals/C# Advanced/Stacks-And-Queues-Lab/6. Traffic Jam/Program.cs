using System;
using System.Collections.Generic;

namespace _6._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            int counter = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input=="end")
                {
                    Console.WriteLine($"{counter} cars passed the crossroads.");
                    Environment.Exit(0);
                }
                else if (input=="green")
                {
                    int minCars = Math.Min(n,cars.Count);

                    for (int i = 0; i < minCars; i++)
                    {
                        string currCar = cars.Dequeue();
                        Console.WriteLine($"{currCar} passed!");
                        counter++;

                    }
                }
                else
                {
                    cars.Enqueue(input);
                }
            }
        }
    }
}
