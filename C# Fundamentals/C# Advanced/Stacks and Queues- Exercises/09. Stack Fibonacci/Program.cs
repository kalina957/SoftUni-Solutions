using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Stack_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<long> stack = new Stack<long>();
            stack.Push(0);
            stack.Push(1);

            for (int i = 0; i < n-1; i++)
            {
                long prevNum = stack.Pop();
                long num = prevNum + stack.Peek();
                stack.Push(prevNum);
                stack.Push(num);
            }
            Console.WriteLine(stack.Peek());
        }
    }
}
