using System;

namespace Neighbours
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerOneDamage = int.Parse(Console.ReadLine());
            int playerTwoDamage = int.Parse(Console.ReadLine());
            int playerOneHealth = 100;
            int playerTwoHealth = 100;
            int counter = 0;

            while (true)
            {


                playerTwoHealth -= playerOneDamage;
                counter++;
                if (playerOneHealth <= 0 || playerTwoHealth <= 0) break;
                
                Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {playerTwoHealth} health.");
                if (counter%3==0)
                {
                    playerTwoHealth += 10;
                    playerOneHealth += 10;
                }
                playerOneHealth -= playerTwoDamage;
                counter++;
                
                    if (playerOneHealth <= 0 || playerTwoHealth <= 0) break;
                Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {playerOneHealth} health.");
                if (counter%3 == 0)
                {
                    playerTwoHealth += 10;
                    playerOneHealth += 10;
                }


            }

            if (playerOneHealth > playerTwoHealth) Console.WriteLine($"Pesho won in {counter}th round.");
            else Console.WriteLine($"Gosho won in {counter}th round.");
        }
    }
}
