using System;

namespace ConsoleTutorial.Examples
{
    public class Calculator
    {
        public static void Run()
        {
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num1 - num2);

            Console.ReadLine();
        }
    }
}
