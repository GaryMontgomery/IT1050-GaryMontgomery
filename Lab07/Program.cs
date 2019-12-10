using System;

namespace Lab07
{
    public class Book
    {
        public string Title { get; }
        public string Author { get; }
        public int Year { get; }
        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }
    }

    class Display
    {
        static void Main()
        {
            var book1 = new Book("A Dance with Dragons", "George R.R. Martin", 2011);
            Console.WriteLine(book1.Title);
            Console.WriteLine(book1.Author);
        }
    }
}
