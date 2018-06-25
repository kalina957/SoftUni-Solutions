using System;
using System.Collections.Generic;
using System.Linq;

namespace Srubsko_Unleashed
{
    class Program
    {
        static void Main(string[] args)
        {
          Dictionary<string,Dictionary<string, List<int>>> dict = new Dictionary<string, Dictionary<string, List<int>>>();
            int dragons = int.Parse(Console.ReadLine());

            for (int i = 0; i < dragons; i++)
            {
                string[] input = Console.ReadLine().Split();
                string type = input[0];
                string name = input[1];
                int damage = 0;
                int health = 0;
                int armor = 0;

                if (input[2] == "null") damage = 45;
                else damage = Convert.ToInt32(input[2]);
                if (input[3] == "null") health = 250;
                else health = Convert.ToInt32(input[3]);
                if (input[4] == "null") armor = 10;
                else armor = Convert.ToInt32(input[4]);

                if (!dict.ContainsKey(type))
                {
                    dict[type]= new Dictionary<string,  List<int>>();
                }
                if (!dict[type].ContainsKey(name))
                {
                    dict[type][name] =new List<int> { 0,0,0};
                }
                dict[type][name][0] = damage;
                dict[type][name][1] = health;
                dict[type][name][2] = armor;
            }
            foreach (var dragon in dict)
            {
                var averageDamage = dragon.Value.Sum(x => x.Value[0]*1.0)/dragon.Value.Count;
                var averageHealth = dragon.Value.Sum(x => x.Value[1]*1.0)/dragon.Value.Count;
                var averageArmor = dragon.Value.Sum(x => x.Value[2]*1.0)/dragon.Value.Count;
                Console.WriteLine($"{dragon.Key}::({averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2})");

                foreach (var dragonType in dragon.Value.OrderBy(x=>x.Key))
                {
                    Console.WriteLine($"-{dragonType.Key} -> damage: {dragonType.Value[0]}, health: {dragonType.Value[1]}, armor: {dragonType.Value[2]}");
                }
            }
        }
    }
}
