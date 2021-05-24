using System;
using System.Collections.Generic;

namespace Projektet
{
    public class Frog
    {
        private static Random generator = new Random();
        private int Hunger = 20; 
        private int Boredome = 0; 
        private bool isAlive = true;
        private string Name;
        private List<string> words = new List<string>();
        
        
        //Inkappslingen är nytt, inte taget ifrån tamagochi spelet vi gjort förut. 
        public virtual void SetName (string newName)
        {
            Name = "";
        }
        public virtual void SetHunger(int newHunger)
        {
            Hunger = Math.Max(newHunger, 0);
        }
        
        public int GetHunger()
        {
            return Hunger;
        }
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

        public void Feed(Food food)
        {
            Food tempfood = Food.foodList.Dequeue();
            Hunger += tempfood.getNourishment();
            Boredome--;
            if(generator.Next(0,2) == 0)
            {
                Food.foodList.Enqueue(new Veggies());
            }
            else
            {
                Food.foodList.Enqueue(new insects());
            }
            
            
        }
        public void ReduceBoredom()
        { 
            Boredome --; 
        }

        public void PrintStats()
        { 
            Console.WriteLine(Hunger + Boredome);
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
