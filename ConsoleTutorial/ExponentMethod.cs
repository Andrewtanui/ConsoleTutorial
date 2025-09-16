using System;

namespace ConsoleTutorial.Examples
{
    public class ExponentMethod
    {
        public static void Run()
        {
            Console.WriteLine(Power(2, 3)); // 2³ = 8
        }

        static int Power(int baseNum, int exponent)
        {
            int result = 1;
            for (int i = 0; i < exponent; i++)
            {
                result *= baseNum;
            }
            return result;
        }
    }
}
