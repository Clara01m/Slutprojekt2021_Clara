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
            // array med de olika grodorna
            System.Console.WriteLine("We currently have 4 frogs. Which frog would you like to help first");
            System.Console.WriteLine("1) Dartpoison frog  2) Goliath frog  3) Tree frog  4) Glass frog");
            String answer = Console.ReadLine(); 
            // en tryparse är inte så nödvändig här egentligen men jag behövde lyckas få med det i koden
            int answ; 
            bool convert = int.TryParse(answer, out answ);
            if (answ == 1)
            {
                CurrentFrog = DartPoison;
            }
            else if (answ == 2)
            {
                CurrentFrog = Goliath;
            }
            else if (answ == 3)
            {
                CurrentFrog = Tree;
            }
            else if (answ == 4)
            {
                CurrentFrog = Glass;
            }
            else 
            {
                 System.Console.WriteLine(" inncorrect answer, you options are 1) Dartpoison frog  2) Goliath frog  3) Tree frog  4) Glass frog");
            }
            // min favorit lösning i koden är att använda CurrentFrog för att inte ehöva skriva samma kod för varje groda seppart
            System.Console.WriteLine("What would you like to call this frog?" );
            
            System.Console.WriteLine("What would you like to do with" + CurrentFrog );
            System.Console.WriteLine();
            System.Console.ReadLine();
            
            System.Console.WriteLine(CurrentFrog.GetHunger());
            Console.ReadLine();


            // löser detta när jag hr extra tid
            // DateTime.Now
            //DateTime t = new DateTime(1984, 10, 12);
            //TimeSpan r = DateTime.Now - t;
            //string d = DateTime.Now.ToLongDateString();

            //DateTime d2 = new DateTime(d);


        // 1 arv, 1 generiska, /inkapslng, /tryparse, 1 utbyte mellan instanser. 







        }
    }
}
