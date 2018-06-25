using System;

namespace Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            int totalSeconds = hours * 3600 + minutes * 60 + seconds;
            float metersPerSecond = (float)meters /(totalSeconds);
            float kilometersPerHour;
            float milesPerHour;
            
                 kilometersPerHour = ( ((float)meters / 1000)/ ((float)totalSeconds/3600));
                 milesPerHour = ((float)meters / 1609) / (((float)totalSeconds / 3600));
            
                
            
            Console.WriteLine(metersPerSecond);
            Console.WriteLine(kilometersPerHour);
            Console.WriteLine(milesPerHour);
        }
    }
}
