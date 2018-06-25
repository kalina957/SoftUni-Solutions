using System;
using System.Linq;

namespace Rectangle_Position
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Rectangle r1 = CalculateRectangle();
            Rectangle r2 = CalculateRectangle();
            var result = r1.Isinside(r2);

            if (result)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }

        }

        private static Rectangle CalculateRectangle()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Rectangle r = new Rectangle { Left = input[0], Top = input[1], Width = input[2], Height = input[3] }; 
            return r;
        }

        class Rectangle
        {
            public int Top { get; set; }
            public int Left { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }
            public int Bottom
            {
                get
                {
                    return Top + Height;
                }
            }
            public int Right
            {
                get
                {
                    return Left + Width;
                }

            }
            public bool Isinside(Rectangle rectangle)
            {
                var leftIsValid = rectangle.Left <= Left;
                var topIsValid = rectangle.Top <= Top;
                var rightIsValid = rectangle.Right >= Right;
                var bottomIsValid = rectangle.Bottom >= Bottom;
                return
                    leftIsValid && topIsValid && rightIsValid && bottomIsValid;
            }
        }
    }
}
