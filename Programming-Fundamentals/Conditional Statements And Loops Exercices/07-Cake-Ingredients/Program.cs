using System;

namespace Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingredient="";
            int counter = 0;
           while(true)
            {
                    ingredient = Console.ReadLine();
                

                if (ingredient == "Bake!")

                {
                    Console.WriteLine($"Preparing cake with {counter} ingredients.");
                    break;
                }
                
                Console.WriteLine($"Adding ingredient {ingredient}.");
                counter++;

            } 
        }
    }
}
