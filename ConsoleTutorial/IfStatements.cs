using System;

namespace ConsoleTutorial.Examples
{
    public class IfStatements
    {
        public static void Run()
        {
            Console.Write("Are you male? (yes/no): ");
            string maleInput = Console.ReadLine()?.Trim().ToLower();
            bool isMale = maleInput == "yes" || maleInput == "y";

            Console.Write("Enter your height in cm: ");
            int height;
            while (!int.TryParse(Console.ReadLine(), out height) || height <= 0)
            {
                Console.Write("Invalid input. Please enter a valid height in cm: ");
            }

            bool isTall = height >= 150;

            if (isMale && isTall)
                Console.WriteLine("You are a tall male");
            else if (isMale && !isTall)
                Console.WriteLine("You are a short male");
            else if (!isMale && isTall)
                Console.WriteLine("You are not male but tall");
            else
                Console.WriteLine("You are not male and not tall");
        }
    }
}
