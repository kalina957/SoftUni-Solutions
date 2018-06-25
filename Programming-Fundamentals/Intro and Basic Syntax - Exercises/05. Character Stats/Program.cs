using System;

namespace _05._Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int CurHealth = int.Parse(Console.ReadLine());
            int MaxHealth = int.Parse(Console.ReadLine());
            int CurEnergy = int.Parse(Console.ReadLine());
            int MaxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine("Health: " + new string('|', CurHealth + 1) + new string('.', MaxHealth - CurHealth) + new string('|', 1));
            Console.WriteLine("Energy: " + new string('|', CurEnergy + 1) + new string('.', MaxEnergy - CurEnergy) + new string('|', 1));

        }
    }
}
