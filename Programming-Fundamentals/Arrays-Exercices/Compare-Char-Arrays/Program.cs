using System;
using System.Linq;

namespace Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)

        {
            char[] arr1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] arr2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            int length = Math.Max(arr1.Length,arr2.Length);
            int counter = 0; 


            if (arr1.Length == arr2.Length)
            {
                for (int i = 0; i < length; i++)
                {
                    if (arr1[i] == arr2[i])
                    {
                        if (i == length - 1)
                        {
                            Console.WriteLine(arr1);
                            Console.WriteLine(arr2); 
                        }
                        counter++;
                    }
                    else
                    {
                        if (arr1[0] < arr2[0])
                        {
                            Console.WriteLine(arr1);
                            Console.WriteLine(arr2);
                        }
                        else
                        {
                            Console.WriteLine(arr2);
                            Console.WriteLine(arr1);
                        }
                        break;
                    }
                }
                
            }
            else
            {
                if (arr1.Length<arr2.Length)
                {
                    Console.WriteLine(arr1);
                    Console.WriteLine(arr2);
                }
                else
                {
                    Console.WriteLine(arr2);
                    Console.WriteLine(arr1);
                }
            }
                      
        }        
    }
}
