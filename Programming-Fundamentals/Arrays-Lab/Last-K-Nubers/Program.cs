using System;
using System.Linq;
namespace Last_K_Nubers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            long[] seq = new long[n];
            seq[0] = 1;
            Console.Write(seq[0]+" ");

            for (int i = 1; i < seq.Length; i++)
            {
                int start = Math.Max(0, i - k);
                for (int j = start; j < i; j++)
                    {
                        seq[i] += seq[j];
                    }
                
                Console.Write(seq[i]+" ");
            }
        }
    }
}
