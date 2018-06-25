using System;


namespace Vowel_Or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());
            
            
                if (symbol=='a'||symbol== 'y'|| symbol == 'e' || symbol == 'i' || symbol == 'u' || symbol == 'o' || symbol == 'A' ||symbol== 'Y' || symbol == 'E' || symbol == 'I' || symbol == 'U' || symbol == 'O') Console.WriteLine("vowel");
            else if (symbol == '0' || symbol == '1' || symbol == '2' || symbol == '3' || symbol == '4' || symbol == '5' || symbol == '6' || symbol == '7' || symbol == '8' || symbol == '9') Console.WriteLine("digit");
            else Console.WriteLine("other");
            
        }
    }
}
