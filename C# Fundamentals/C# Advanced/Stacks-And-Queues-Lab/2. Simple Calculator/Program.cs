using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Stack<string> text = new Stack<string>(input.Reverse());

            while (text.Count>1)
            {
                int leftOperand = int.Parse(text.Pop());
                string sign = text.Pop();
                int rightOperand = int.Parse(text.Pop());

                switch (sign)
                {
                    case "+":
                        string result = (leftOperand + rightOperand).ToString();
                        text.Push(result);
                        break;

                    case "-":
                        result = (leftOperand - rightOperand).ToString();
                        text.Push(result);
                        break;
                }
            }
            Console.WriteLine(text.Pop());
        }
    }
}
