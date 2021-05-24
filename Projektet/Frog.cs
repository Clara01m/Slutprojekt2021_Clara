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
            Name = newName;
        }
        public string getName ()
        {
            return Name;
        }

        //kontrollera hungern med inkapsling
        public virtual void SetHunger(int newHunger)
        {
            Hunger = Math.Max(newHunger, 0);
        }
        
        public int GetHunger()
        {
            return Hunger;
        }
        //Lär grodan ett ord :) 
        public void Teach(string word)
        {
            words.Add(word); 
            ReduceBoredom();
        }
        //Få grodan att säga ett av orden 
         public void Hi()
        { 
            int wordIndex = generator.Next(words.Count);

            System.Console.WriteLine(words[wordIndex]);

            ReduceBoredom();
        }
        // Mata grodan, kopplad till klassen food med en queue
        public void Feed()
        {
            Food tempfood = Food.foodList.Dequeue();
            Hunger += tempfood.getNourishment();
            Boredome--;
            PrintStats();
            if(generator.Next(0,2) == 0)
            {
                Food.foodList.Enqueue(new Veggies());
            }
            else
            {
                Food.foodList.Enqueue(new insects());
            }
          // denna används i andra instanser här för att minska boredome  
            
        }
        public void ReduceBoredom()
        { 
            Boredome --; 
        }
        // detta ger ut ens viktigaste stats
        public void PrintStats()
        { 
            Console.WriteLine("Your hunger is at " + Hunger + ", don't reach 0. Your boredome is at " + Boredome + ", don't reach 20");
        }
        // denna checkar om grodan mår bra, annars förlorar man grodan
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
        // denna går ner för att grodan mår dåligt om den blir lämnad ensam för länge
         public void Tick()
        {
            Hunger --; 
            Boredome ++;
            if (Hunger<0 || Boredome>20)
            {
                isAlive = false; 
            }
        }
    }
}
