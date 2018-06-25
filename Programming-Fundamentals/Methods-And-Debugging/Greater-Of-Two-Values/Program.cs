using System;

namespace Greater_Of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            if (type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                int max = GetMax(first,second);
                Console.WriteLine(max);
            }
            else if (type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                char max = GetMax(first, second);
                Console.WriteLine(max);
            }
            else
            {
                string first =Console.ReadLine();
                string second = Console.ReadLine();
                string max = GetMax(first, second);
                Console.WriteLine(max);
            }
        }
        static int GetMax(int first, int second)
        {
           int max= Math.Max(first, second);
            return max;
        }
        static char GetMax(char first, char second)
        {
            char max = (char)Math.Max(Convert.ToInt32(first), Convert.ToInt32(second));
            return max;
        }
        static string GetMax(string first, string second)
        {
            if (first.CompareTo(second) >= 0)
            {
                return first;
            }
            else return second;
        }
    }
}
