using System;

namespace ConsoleTutorial.Examples
{
    public static class MathHelper
    {
        public static int Square(int x)
        {
            return x * x;
        }
    }

    public class StaticMethods
    {
        public static void Run()
        {
            Console.WriteLine(MathHelper.Square(5));
        }
    }
}
