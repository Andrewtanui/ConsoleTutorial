using System;

namespace ConsoleTutorial.Examples
{
    public class SwitchDemo
    {
        public static void Run()
        {
            Console.Write("Enter a grade (A, B, C, D, F): ");
            string grade = Console.ReadLine();

            switch (grade)
            {
                case "A": Console.WriteLine("Excellent!"); break;
                case "B": Console.WriteLine("Good job"); break;
                case "C": Console.WriteLine("Fair"); break;
                case "D": Console.WriteLine("Poor"); break;
                case "F": Console.WriteLine("Fail"); break;
                default: Console.WriteLine("Invalid grade"); break;
            }
        }
    }
}
