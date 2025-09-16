using System;

namespace ConsoleTutorial.Examples
{
    public class WhileLoop
    {
        public static void Run()
        {
            int index = 1;
            while (index <= 10)
            {
                Console.WriteLine($"Index: {index}");
                index++;
            }
        }
    }
}
