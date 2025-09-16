using System;

namespace ConsoleTutorial.Examples
{
    public class MethodsDemo
    {
        public static void Run()
        {
            SayHi("Andrew", 21);
            SayHi("Grace", 20);
        }

        static void SayHi(string name, int age)
        {
            Console.WriteLine($"Hello {name}, you are {age}");
        }
    }
}
