using System;
using System.Collections;
using System.ComponentModel;

namespace ReviewProblems
{

    struct BookStruct
    {
        public string title;
        public int publicationYear;


    };

        public class Author 
        {
           public string name;
           public int birthyear;
            ArrayList author = new ArrayList();
            public void AddBooks(object book)
            {
                 author.Add(book);
            }

            

            public void DisplayBooks()
            {
                foreach (BookStruct item in author)
                {
                Console.WriteLine("Book Name :"+item.title+" --->publication year :"+item.publicationYear);
                }
           
            }

         
    }
    internal class Program 
    {
        
        static void Main(string[] args)
        {

            Author au1= new Author();
            au1.name = "Arun";
            au1.birthyear = 1990;
            BookStruct ab = new BookStruct();
            Console.WriteLine("Author name  :" + au1.name);
            Console.WriteLine("Author name  :" + au1.birthyear);      
            ab.title = "Got to Know";
            ab.publicationYear = 1987;
            au1.AddBooks(ab);
            ab.title = "Hello c#";
            ab.publicationYear = 2002;
            au1.AddBooks(ab);
            au1.DisplayBooks();

            Console.WriteLine();

            Author au2 = new Author();
            au2.name = "Amulya";
            au2.birthyear = 2000;
            Console.WriteLine("Author name  :" + au2.name);
            Console.WriteLine("Author name  :" + au2.birthyear);
            BookStruct ab2 = new BookStruct();
            ab2.title = "Youth";
            ab2.publicationYear = 1987;
            au2.AddBooks(ab2);
            ab2.title = "Fier";
            ab2.publicationYear = 2002;
            au2.AddBooks(ab2);
            au2.DisplayBooks();


        }
    }
}
