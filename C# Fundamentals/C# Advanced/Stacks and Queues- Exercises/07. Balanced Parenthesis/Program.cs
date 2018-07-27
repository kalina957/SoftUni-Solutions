using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> openPatenthesis = new Stack<char>();
            bool flag = true;

            foreach (var p in input)
            {
                switch (p)
                {
                    case '(':
                    case '[':
                    case '{':
                        openPatenthesis.Push(p);
                        break;

                    case ')':
                        if (!openPatenthesis.Any())
                        {
                            flag = false;
                        }
                        else if(openPatenthesis.Pop()!='(')
                        {
                            flag = false;
                        }
                        break;

                    case ']':
                        if (!openPatenthesis.Any())
                        {
                            flag = false;
                        }
                        else if (openPatenthesis.Pop() != '[')
                        {
                            flag = false;
                        }
                        break;

                    case '}':
                        if (!openPatenthesis.Any())
                        {
                            flag = false;
                        }
                        else if (openPatenthesis.Pop() != '{')
                        {
                            flag = false;
                        }
                        break;

                }
                if (!flag)
                {
                    break;
                }
            }

            Console.WriteLine(flag ? "YES" : "NO");

        }
    }
}
