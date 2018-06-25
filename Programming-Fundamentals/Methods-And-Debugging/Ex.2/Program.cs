using System;

namespace Ex._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var division = Divide(1,3);
            Console.WriteLine(division);
            string currTime = Console.ReadLine();
            var time = DateTime.Parse(currTime);
            Console.WriteLine(time);
        }
      
            static (int result, int reminder) Divide(int x, int y)
            {
                int result = x / y;
                int reminder = x % y;
            
                return (result, reminder);
            }
       
    }
}
