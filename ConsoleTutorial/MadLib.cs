using System;

namespace ConsoleTutorial.Examples
{
    public class MadLib
    {
        public static void Run()
        {
            Console.Write("Enter a color: ");
            string color = Console.ReadLine();
            Console.Write("Enter a plural noun: ");
            string pluralNoun = Console.ReadLine();
            Console.Write("Enter a celebrity: ");
            string celebrity = Console.ReadLine();

            Console.WriteLine($"Roses are {color}");
            Console.WriteLine($"{pluralNoun} are blue");
            Console.WriteLine($"I love {celebrity}");
        }
    }
}
