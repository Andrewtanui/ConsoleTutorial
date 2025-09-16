using System;

namespace ConsoleTutorial.Examples
{
    public class BetterCalculator
    {
        public static void Run()
        {
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operator (+ - * /): ");
            string op = Console.ReadLine();

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            switch (op)
            {
                case "+": result = num1 + num2; break;
                case "-": result = num1 - num2; break;
                case "*": result = num1 * num2; break;
                case "/": result = num1 / num2; break;
                default: Console.WriteLine("Invalid Operator"); break;
            }

            Console.WriteLine($"Result = {result}");
        }
    }
}
