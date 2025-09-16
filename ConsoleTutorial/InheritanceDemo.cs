using System;

namespace ConsoleTutorial.Examples
{
    public class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("The chef makes chicken");
        }
        public void MakeSalad()
        {
            Console.WriteLine("The chef makes salad");
        }
        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The chef makes bbq ribs");
        }
    }

    public class ItalianChef : Chef
    {
        public void MakePasta()
        {
            Console.WriteLine("The Italian chef makes pasta");
        }
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Italian chef makes pizza");
        }
    }

    public class InheritanceDemo
    {
        public static void Run()
        {

            Chef chef1 = new Chef();
            chef1.MakeSpecialDish();

            ItalianChef italianChef = new ItalianChef();
            italianChef.MakeSpecialDish();
            
            Chef chef = new ItalianChef();
            chef.MakeSpecialDish();
            
        }
    }
}
