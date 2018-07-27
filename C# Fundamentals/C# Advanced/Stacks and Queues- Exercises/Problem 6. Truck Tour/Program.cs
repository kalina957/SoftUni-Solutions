using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Queue<int[]> queue = new Queue<int[]>();

            for (int i = 0; i < n; i++)
            {
                var pump = Console.ReadLine().Split().Select(int.Parse).ToArray();
                queue.Enqueue(pump);
            }

            for (int currStart = 0; currStart < n; currStart++)
            {
                int truckFuel = 0;
                bool isSolution = true;

                for (int pumpsPast = 0; pumpsPast < n; pumpsPast++)
                {
                    int[] currPump = queue.Dequeue();
                    queue.Enqueue(currPump);
                    int pumpFuel = currPump[0];
                    int nextPumpDistance = currPump[1];
                    truckFuel += pumpFuel - nextPumpDistance;

                    if (truckFuel<0)
                    {
                        currStart +=pumpsPast;
                        isSolution = false;
                        break;
                    }
                }
                if (isSolution)
                {
                    Console.WriteLine(currStart);
                    Environment.Exit(0);
                }
            }
        }
    }
}
