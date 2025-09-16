using System;

namespace ConsoleTutorial.Examples
{
    public class StringsDemo
    {
        public static void Run()
        {
            string phrase = "Hello C# World";
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.Contains("World"));
            Console.WriteLine(phrase[0]);
            Console.WriteLine(phrase.IndexOf("C#"));
            Console.WriteLine(phrase.Substring(6, 2));
        }
    }
}
