using System;

namespace ConsoleTutorial.Examples
{
    public class Movie
    {
        public string Title;
        public string Director;
        public int Year;

        public Movie(string title, string director, int year)
        {
            Title = title;
            Director = director;
            Year = year;
        }
    }

    public class ConstructorsDemo
    {
        public static void Run()
        {
            Movie m1 = new Movie("Inception", "Nolan", 2010);
            Console.WriteLine($"{m1.Title} ({m1.Year}), directed by {m1.Director}");
        }
    }
}
