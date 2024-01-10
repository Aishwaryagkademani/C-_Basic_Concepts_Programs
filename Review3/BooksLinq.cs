using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Review3
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

    }
    internal class BooksLinq
    {
        public static void BooksQueries()
        {
            List<Book> bList = new List<Book>()
            {
                new Book{Title="Fly High",Author="Aman Guptha",Year=2000},
                new Book{Title="Jai hinda",Author="Barat",Year=1900},
                new Book{Title="Raman Ideas",Author="Trivani",Year=2013},
                new Book{Title="Try",Author="Varun",Year=2020},
                new Book{Title="Youth",Author="Varun",Year=2015},
                new Book{Title="Guide of Life",Author="Ravindar",Year=1999},
            };
            Console.WriteLine("Books Original List is.......");
            foreach (Book book in bList)
            {
                Console.WriteLine("Title : {0} , Author : {1} , Year : {2}", book.Title, book.Author, book.Year);
            }

            Console.WriteLine();
            Console.WriteLine("Books published after year 2000 are .........");
            var booksAfterYear = (from book in bList where book.Year > 2000 select book).ToList();
            foreach(Book book in booksAfterYear )
            {
                Console.WriteLine("Title : {0} , Author : {1} , Year : {2}",book.Title,book.Author,book.Year);
            }

            Console.WriteLine();
            Console.WriteLine("Books authored by varun .........");
            var bAuthored = (from book in bList where book.Author == "Varun" select book).ToList();
            foreach (var book in bAuthored)
            {
                Console.WriteLine("Title : {0}", book.Title);
            }

            Console.WriteLine();
            Console.WriteLine("Book list sorted based on Titles of the books .........");
            var SortedListOnTitle = (from book in bList select book).OrderBy(x=>x.Title) .ToList();
            foreach (Book book in SortedListOnTitle)
            {
                Console.WriteLine("Title : {0} , Author : {1} , Year : {2}", book.Title, book.Author, book.Year);
            }

        }
    }
}
