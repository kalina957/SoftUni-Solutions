using System;

namespace Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string packageType = Console.ReadLine();

            if (packageType=="Normal")
            {
               
                if (people <= 50)
                {

                    Console.WriteLine($"We can offer you the Small Hall");
                    Console.WriteLine($"The price per person is {(2500 + 500 - (3000 * 0.05)) / people:f2}$");
                }
                else if (people <= 100)
                {
                    Console.WriteLine($"We can offer you the Terrace");
                    Console.WriteLine($"The price per person is {(5000 + 500 - (5500 * 0.05)) / people:f2}$");
                }
                else if (people <= 120)
                {
                    Console.WriteLine($"We can offer you the Great Hall");
                    Console.WriteLine($"The price per person is {(7500 + 500 - (8000 * 0.05)) / people:f2}$");
                }
                else
                    Console.WriteLine("We do not have an appropriate hall.");
            }
            else if (packageType=="Gold")
            {
             

                if (people <= 50)
                {
                    Console.WriteLine($"We can offer you the Small Hall");
                    Console.WriteLine($"The price per person is {(2500 + 750 - (3250 * 0.1)) / people:f2}$");
                }
                else if (people <= 100)
                {
                    Console.WriteLine($"We can offer you the Terrace");
                    Console.WriteLine($"The price per person is {(5000 + 750 - (5750 * 0.1)) / people:f2}$");
                }
                else if (people <= 120)
                {
                    Console.WriteLine($"We can offer you the Great Hall");
                    Console.WriteLine($"The price per person is {(7500 + 750 - (8250 * 0.1)) / people:f2}$");
                }
                else Console.WriteLine("We do not have an appropriate hall.");
            }
            else 
            {  
                if (people <= 50)
                {
                    Console.WriteLine($"We can offer you the Small Hall");
                    Console.WriteLine($"The price per person is {(2500 + 1000 - (3500 * 0.15)) / people:f2}$");
                }
                else if (people <= 100)
                {
                    Console.WriteLine($"We can offer you the Terrace");
                    Console.WriteLine($"The price per person is {(5000 + 1000 - (6000 * 0.15)) / people:f2}$");
                }
                else if (people <= 120)
                {
                    Console.WriteLine($"We can offer you the Great Hall");
                    Console.WriteLine($"The price per person is {(7500 + 1000 - (8500 * 0.15)) / people:f2}$");
                }
                else
                    Console.WriteLine("We do not have an appropriate hall.");
                
            }

        }
    }
}
