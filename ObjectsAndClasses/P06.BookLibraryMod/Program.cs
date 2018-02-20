using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.PortableExecutable;

namespace P06.BookLibraryMod
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
    }

    class Library
    {
        public List<Book> Books { get; set; }

        public Library()
        {
            Books = new List<Book>();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Library library = new Library();
            while (n-- > 0)
            {
                Book book = new Book();
                var input = Console.ReadLine().Split().ToList();
                book.Title = input[0];
                book.Author = input[1];
                book.Publisher = input[2];
                book.ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                book.ISBN = input[4];
                book.Price = decimal.Parse(input[5]);

                library.Books.Add(book);
            }

            var yearToCompare = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            var bookAndYear = new SortedDictionary<string, DateTime>();

            foreach (Book book in library.Books.Where(r => r.ReleaseDate > yearToCompare))
            {
                    bookAndYear[book.Title] = book.ReleaseDate;
            }

            foreach (var kvp in bookAndYear.OrderBy(v => v.Value).ThenBy(k => k.Value))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }

    
}
