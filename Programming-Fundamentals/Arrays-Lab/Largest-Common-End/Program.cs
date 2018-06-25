using System;
using System.Linq;

namespace Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text1 = Console.ReadLine().Split(' ').ToArray();
            string[] text2 = Console.ReadLine().Split(' ').ToArray();
            int min = Math.Min(text1.Length, text2.Length);
            int length1 = 0;
            int length2 = 0;

            for (int i = 0; i < min; i++)
            {
                if (text1[i] == text2[i]) length1++;
                else break;
            }

            text1 = text1.Reverse().ToArray();
            text2 =  text2.Reverse().ToArray();

            for (int i = 0 ; i < min; i++)
            {
                if (text1[i] == text2[i]) length2++;
                else break;
            }
             Console.WriteLine(Math.Max(length1,length2));
        }
    }
}
