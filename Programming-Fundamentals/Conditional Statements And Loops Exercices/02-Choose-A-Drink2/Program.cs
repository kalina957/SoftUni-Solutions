using System;

namespace Choose_A_Drink2
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            switch (profession)
            {
                case "Athlete": Console.WriteLine($"The {profession} has to pay {quantity*0.70:f2}."); break;
                case "Businessman":
                case "Businesswoman": Console.WriteLine($"The {profession} has to pay {quantity * 1.00:f2}."); break;
                case "SoftUni Student": Console.WriteLine($"The {profession} has to pay {quantity * 1.70:f2}."); break;
                default:  Console.WriteLine($"The {profession} has to pay {quantity * 1.20:f2}."); break;
                    
            }
        }
    }
}
