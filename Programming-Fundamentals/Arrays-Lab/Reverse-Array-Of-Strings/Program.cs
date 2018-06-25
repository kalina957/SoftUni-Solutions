using System;
using System.Linq;

namespace Reverse_Array_Of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();
            Array.Reverse(arr);
            Console.WriteLine(String.Join(' ',arr));
            
        }
    }
}
