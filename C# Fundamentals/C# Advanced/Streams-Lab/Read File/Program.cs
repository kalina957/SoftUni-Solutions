using System;
using System.IO;


namespace Read_File
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var stream = new StreamReader(@"C:\Users\User\Desktop\SoftUni-Solutions\SoftUni-Solutions\C# Fundamentals\C# Advanced\Streams-Lab\Read File\Program.cs"))
            {
                var lineNumber = 1;
                string line ;

                while ((line = stream.ReadLine())!=null)
                {
                    Console.WriteLine($"Line {lineNumber}: "+line);
                }
            }
        }
    }
}
