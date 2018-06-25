using System;

namespace Test_Numbers
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
            {if (playerOneHealth > 0 || playerTwoHealth > 0)
                {
                    if (counter==3)
                    {
                        playerOneHealth += 10;
                        playerTwoHealth += 10;
                    }
                    playerTwoHealth -= playerOneDamage;
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {playerTwoHealth} health");
                    playerOneHealth -= playerTwoDamage;
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {playerOneHealth } health");
                    counter++;
                }
                else break;
            }

        }
    }
}
