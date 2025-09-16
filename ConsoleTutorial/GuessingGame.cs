using System;

namespace ConsoleTutorial.Examples
{
    public class GuessingGame
    {
        public static void Run()
        {
            string secretWord = "comrade";
            string guess = "";
            int attempts = 0;
            int maxAttempts = 3;

            while (guess != secretWord && attempts < maxAttempts)
            {
                Console.Write("Enter guess: ");
                guess = Console.ReadLine();
                attempts++;
            }

            if (guess == secretWord)
                Console.WriteLine("You Win!");
            else
                Console.WriteLine("Out of attempts, You Lose!");
        }
    }
}
