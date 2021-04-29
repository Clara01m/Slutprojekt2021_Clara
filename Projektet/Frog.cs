using System;
using System.Collections.Generic;

namespace Projektet
{
    public class Frog
    {
        static Random generator = new Random();
        public int Hunger = 20; 
        public int Boredome = 0; 
        bool isAlive = true;
        public string Name = "";
        public List<string> words = new List<string>();

        


         public void Hi()
        { 
            int wordIndex = generator.Next(words.Count);

            System.Console.WriteLine(words[wordIndex]);

            ReduceBoredom();
        }

        public void Teach(string word)
        {
            words.Add(word); 
            ReduceBoredom();
        }


        public string GetAlive ()
        {
            string returnString;

            if (isAlive == true)
            {
                returnString = "They're doing just fine";
                return returnString;
            }
            else
            {
               returnString = "Oh no!!! This is not going to look good for our daycare!";
                return returnString;
            }
        }
          public void Feed()
        {
            Hunger++;
        }
         public void PrintStats()
        { 
            Console.WriteLine(Hunger + Boredome);
        }
        public void ReduceBoredom()
        { 
            Boredome --; 
        }
         public void Tick()
        {
            Hunger --; 
            Boredome ++;
            if (Hunger<0 || Boredome>15)
            {
                isAlive = false; 
            }
        }
    }
}
