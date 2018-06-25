using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Book_Library_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Library library = new Library();
            List<Book> books = new List<Book>();

            for (int i = 0; i < n; i++)
            {
                Book Book = ReadBook();
                books.Add(Book);
            }
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy",CultureInfo.InvariantCulture);
            library.Books = books;
            PrintBooks(library, date);
        }

       
        private static void PrintBooks(Library library,DateTime date)
        {
            foreach (var item in library.Books.Where(x=>x.ReleaseDate>date).OrderBy(x=>x.ReleaseDate).ThenBy(x=>x.Title))

            {
                Console.WriteLine($"{item.Title} -> {item.ReleaseDate.ToString("dd.MM.yyyy")}");
            }
        }

        private static Book ReadBook()
        {
            string[] input = Console.ReadLine().Split();
            Book book = new Book
            {
                Title = input[0],
                Author = input[1],
                Publisher = input[2],
                ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy",
                CultureInfo.InvariantCulture),
                ISBN = int.Parse(input[4]),
                Price = decimal.Parse(input[5])
            };
            return book;
        }
    }
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int ISBN { get; set; }
        public decimal Price { get; set; }
    }
    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
}
