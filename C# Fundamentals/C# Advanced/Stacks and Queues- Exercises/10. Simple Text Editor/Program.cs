using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string text = string.Empty;
            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string operation = input[0];

                switch (operation)
                {
                    case "1":
                        stack.Push(text);
                        string someText = input[1];
                        text+=someText;
                        break;

                    case "2":
                        stack.Push(text);
                        int count = int.Parse(input[1]);
                            text = text.Substring(0, text.Length - count);
                        break;

                    case "3":
                        int index = int.Parse(input[1]);
                        char result = text[index-1];
                        Console.WriteLine(result);
                        break;

                    case "4":
                        text = stack.Pop();
                        break;
                }
            }
        }
    }
}
