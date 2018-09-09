using System;

namespace _3._Recursive_Drawing
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            DrawFigure(num);
        }

        private static void DrawFigure(int num)
        {
            if (num == 0)
            {
                return;
            }
            Console.WriteLine(new string('*', num));
            DrawFigure(num - 1);
            Console.WriteLine(new string('#', num));

        }
        
        
    }
}
