using System;

namespace ConsoleTutorial.Examples
{
    public class Arrays2D
    {
        public static void Run()
        {
            int[,] numberGrid = {
                {1, 2},
                {3, 4},
                {5, 6}
            };

            Console.WriteLine(numberGrid[0, 1]); // 2

            for (int i = 0; i < numberGrid.GetLength(0); i++)
            {
                for (int j = 0; j < numberGrid.GetLength(1); j++)
                {
                    Console.Write(numberGrid[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
