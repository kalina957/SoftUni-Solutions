using System;

namespace Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] phrases = new string[] { " Excellent product."
                , " Such a great product."
                , " I always use that product."
                , " Best product of its category."
                , " Exceptional product."
                , " I can’t live without this product."
        };
            string[] events = new string[] {  " Now I feel good."
                , " I have succeeded with this product."
                , "Makes miracles. I am happy of the results!"
                , " I cannot believe but now I feel awesome"
                , " Try it yourself, I am very satisfied."
                , " I feel great!" };
            string[] autors = new string[] { " Diana ", " Petya ", " Stella ", " Elena ", " Katya ", " Iva ", " Annie ", " Eva " };

            string[] cities = new string[]  { " Burgas ", " Sofia ", " Plovdiv ", " Varna ", " Ruse " };

            Random rnd = new Random();
            Console.WriteLine(phrases[rnd.Next(0, phrases.Length)].Trim() + events[rnd.Next(0, events.Length)] + autors[rnd.Next(0, autors.Length)] +"-"+ cities[rnd.Next(0, cities.Length)]);
        }
    }
}
