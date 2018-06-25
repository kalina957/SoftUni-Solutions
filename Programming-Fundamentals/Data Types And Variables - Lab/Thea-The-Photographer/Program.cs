using System;

namespace Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long numberOfPictures = long.Parse(Console.ReadLine());
            long filterTime = long.Parse(Console.ReadLine());
            long filterFactor = long.Parse(Console.ReadLine());
            long uploadingTime = long.Parse(Console.ReadLine());
            double decentPictures = Math.Ceiling(numberOfPictures * (filterFactor*0.01));
            long totalTime = numberOfPictures * filterTime + (long)decentPictures * uploadingTime;
 
            TimeSpan time = TimeSpan.FromSeconds(totalTime);
            string timeNeeded = time.ToString(@"d\:hh\:mm\:ss");
            Console.WriteLine(timeNeeded);
        }
    }
}
