using System;

namespace Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            for (int i = 0; i < input.Length; i++)
            {
                Random rnd = new Random();
                int pos = rnd.Next(0,input.Length);
                string curr = input[pos];
                input[pos] = input[i];
                input[i] = curr;
                
            }
            Console.WriteLine(String.Join("\r\n",input));
        }
    }
}
