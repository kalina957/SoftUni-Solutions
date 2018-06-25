using System;
using System.Linq;
namespace Numbers_In_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] num = Console.ReadLine().ToArray();

            for (int i = 0; i < num.Length / 2; i++) PrintReverseNum(num, i, num.Length - 1 - i);
            Console.WriteLine(string.Join("", num));
        }
        static void PrintReverseNum(char[] num, int i,int j)
            {
            var oldElement = num[i];
                num[i]=num[j];
                num[j] = oldElement;
         }
    }
}
