using System;

namespace Projektet
{
    public class DartPoisonFrog : Frog
    {
        
        public void SetHunger(int newHunger)
        {
            Hunger = Math.Max(newHunger, 0);
        }


    }
}
