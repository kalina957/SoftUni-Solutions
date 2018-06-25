using System;

namespace Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string statement = Console.ReadLine();
            bool value = Convert.ToBoolean(statement);
            if (value) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
}
