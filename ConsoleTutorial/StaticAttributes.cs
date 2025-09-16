using System;

namespace ConsoleTutorial.Examples
{
    public class StudentWithCount
    {
        public string Name;
        public static int StudentCount = 0;

        public StudentWithCount(string name)
        {
            Name = name;
            StudentCount++;
        }
    }

    public class StaticAttributes
    {
        public static void Run()
        {
            StudentWithCount s1 = new StudentWithCount("Lelan");
            StudentWithCount s2 = new StudentWithCount("Andrew");
            StudentWithCount s3 = new StudentWithCount("Tanui");

            Console.WriteLine($"Total students: {StudentWithCount.StudentCount}");
        }
    }
}
