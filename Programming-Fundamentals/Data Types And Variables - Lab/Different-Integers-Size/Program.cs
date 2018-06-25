using System;


namespace Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        { string  num =Console.ReadLine() ;
            try
            {
                long number = long.Parse(num);
                Console.WriteLine($"{num} can fit in:");
                if (number >= SByte.MinValue && number <= SByte.MaxValue) Console.Write("* sbyte\n");
                if (number >= Byte.MinValue && number <= Byte.MaxValue) Console.Write("* byte\n");
                if (number >= -32768 && number <= 32767) Console.Write("* short\n");
                if (number >= 0 && number <= 65535) Console.Write("* unshort\n");
                if (number >= Int32.MinValue && number <= Int32.MaxValue) Console.Write("* int\n");
                if (number >= UInt32.MinValue && number <= UInt32.MaxValue) Console.Write("* uint\n");
                if (number >= -9223372036854775808 && number <= 9223372036854775807) Console.Write("* long\n");
                
            }
            catch (Exception)
            {

                Console.WriteLine($"{num} can't fit in any type");
            }
           
           

        }
    }
}
