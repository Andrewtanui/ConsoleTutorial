using System;

namespace ConsoleTutorial.Examples
{
    public class ReturnDemo
    {
        public static void Run()
        {
            int result = Cube(3);
            Console.WriteLine($"3 cubed = {result}");
        }

        static int Cube(int num)
        {
            return num * num * num;
        }
    }
}
