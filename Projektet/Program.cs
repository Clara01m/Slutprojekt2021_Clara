using System;

namespace Projektet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your new job at the Froggy Daycare");
            Console.WriteLine("Your job is to keep them all happy and healthy");
            Frog DartPoison = new DartPoisonFrog();
            Frog Goliath = new GoliathFrog(); 
            Frog Tree = new TreeFrog();
            Frog Glass = new GlassFrog();
            Frog CurrentFrog = new Frog();

            Frog[] TheFrogs = {DartPoison, Goliath, Tree, Glass};

            CurrentFrog = DartPoison;

            System.Console.WriteLine(CurrentFrog.GetHunger());
            Console.ReadLine();

            // DateTime.Now

            DateTime t = new DateTime(1984, 10, 12);

            TimeSpan r = DateTime.Now - t;

            string d = DateTime.Now.ToLongDateString();

            //DateTime d2 = new DateTime(d);










        }
    }
}
