using System;
using   System.Numerics;

namespace Centuries_To_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            double days = years * 365.2422;
            int hours = (int)days * 24;
            uint minutes = (uint)hours * 60;
            long seconds = (long)minutes * 60;
            long milliseconds = seconds * 1000;
            ulong microseconds = (ulong)milliseconds * 1000;
            BigInteger nanoseconds = (BigInteger)microseconds * 1000;



            Console.WriteLine($"{centuries} centuries = {years} years = {Math.Floor(days)} days = {hours} hours = {minutes} minutes = { seconds} seconds = { milliseconds} milliseconds = { microseconds} microseconds = { nanoseconds} nanoseconds");
        }
    }
}
