using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;

namespace P05.BookLibrary
{
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

            var authorPrice = new SortedDictionary<string, decimal>();
            foreach (Book book in library.Books)
            {
                if (!authorPrice.ContainsKey(book.Author))
                {
                    authorPrice[book.Author] = book.Price;
                }
                else
                {
                    authorPrice[book.Author] += book.Price;

                }
            }

            foreach (var kvp in authorPrice.OrderByDescending(v => v.Value).ThenBy(k => k.Value))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }

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
}
