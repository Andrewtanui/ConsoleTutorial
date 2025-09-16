using System;

namespace ConsoleTutorial.Examples
{
    public class Book
    {
        public string Title;
        public string Author;
        public int Pages;
    }

    public class ClassesObjects
    {
        public static void Run()
        {
            Book book1 = new Book();
            book1.Title = "C# Fundamentals";
            book1.Author = "Tanui";
            book1.Pages = 250;

            Console.WriteLine($"{book1.Title} by {book1.Author}");
        }
    }
}
