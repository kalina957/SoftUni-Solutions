﻿using System;

namespace Centuries_To_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());
            ushort years = (ushort)(centuries * 100);
            uint days = (uint)(365.2422 * years);
            ulong hours = (ulong)days * 24;
            long minutes = (long)(hours * 60);

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}