using System;

namespace Word_In_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            string noun = Console.ReadLine();

            if (noun.EndsWith("y"))
            {
               noun=  noun.Remove(noun.Length-1);
                Console.WriteLine(noun+"ies");
            }
            else if (noun.EndsWith("o") || noun.EndsWith("s") || noun.EndsWith("z") || noun.EndsWith("x") || noun.EndsWith("sh") || noun.EndsWith("ch"))
            {
                Console.WriteLine(noun + "es");
            }
            else
            {
                Console.WriteLine(noun+"s");
            }
        }
    }
}
