using System;

namespace ConsoleTutorial.Examples
{
    public class Student
    {
        public string Name;
        public double GPA;

        public bool HasHonors()
        {
            return GPA >= 3.5;
        }
    }

    public class ObjectMethods
    {
        public static void Run()
        {
            Student s1 = new Student { Name = "Lelan", GPA = 3.8 };
            Student s2 = new Student { Name = "Andrew", GPA = 3.4 };
            Console.WriteLine($"{s1.Name} honors: {s1.HasHonors()}");
            Console.WriteLine($"{s2.Name} honors: {s2.HasHonors()}");
        }
    }
}
