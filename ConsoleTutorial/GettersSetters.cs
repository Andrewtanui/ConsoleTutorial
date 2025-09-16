using System;

namespace ConsoleTutorial.Examples
{
    public class Song
    {
        private string rating;

        public string Title { get; set; }
        public string Artist { get; set; }

        public string Rating
        {
            get { return rating; }
            set
            {
                if (value == "G" || value == "PG" || value == "R")
                    rating = value;
                else
                    rating = "NR"; 
            }
        }
    }

    public class GettersSetters
    {
        public static void Run()
        {
            Song s1 = new Song { Title = "Tujiangalie", Artist = "Sauti Sol", Rating = "PG" };
            Console.WriteLine($"{s1.Title} ({s1.Rating})");
        }
    }
}
