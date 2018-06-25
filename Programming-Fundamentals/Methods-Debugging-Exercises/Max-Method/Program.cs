using System;

namespace Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMax(first,second,third));
        }
        static int GetMax(int first, int second,int third)
        {
            int result1 = Math.Max(first, second);
            int result2 = Math.Max(result1, third);
            return result2;
        }
    }
}
