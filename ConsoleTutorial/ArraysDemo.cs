using System;

namespace ConsoleTutorial.Examples
{
    public class ArraysDemo
    {
        public static void Run()
        {
            int[] numbers = { 4, 8, 15, 16, 23, 42 };
            Console.WriteLine(numbers[0]);
            
            numbers[1] = 99;
            Console.WriteLine(numbers[1]);

            string[] friends = new string[3];
            friends[0] = "Alice";
            friends[1] = "Bob";
            friends[2] = "Charlie";
            Console.WriteLine(string.Join(", ", friends));
        }
    }
}
