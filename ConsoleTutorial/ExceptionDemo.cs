using System;

namespace ConsoleTutorial.Examples
{
    public class ExceptionDemo
    {
        public static void Run()
        {
            try
            {
                Console.Write("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"You entered {num}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            finally
            {
                Console.WriteLine("Program finished.");
            }
        }
    }
}
