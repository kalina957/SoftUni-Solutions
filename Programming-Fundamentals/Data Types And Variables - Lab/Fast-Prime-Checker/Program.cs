using System;

namespace Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 2; i <= number; i++)
            {
                
                int j ;
                bool IsTrue = true;

                for ( j = 2; j <=number ; j++)
                {
                    
                    if (i % j == 0)
                    {
                        IsTrue = false;
                        break;
                    }
                   
                }
                Console.WriteLine($"{ i} -> { IsTrue}");
            }
        }
    }
}
