using System;

namespace Count_The_Integer
{
    class Program
    {
        static void Main(string[] args)
        { int sum = 0;

           
                while (true)
                {
                    try
                    {
                        int num = int.Parse(Console.ReadLine());
                        sum++;
                    }

                    catch (Exception)
                    {
                        Console.WriteLine(sum);
                        break;
                    }

                }
            }
        }
    }


