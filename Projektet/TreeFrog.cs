using System;

namespace Projektet
{
    public class TreeFrog : Frog
    {
        
        public void SetHunger(int newHunger)
        {
            Hunger = Math.Max(newHunger, 0);
        }

    }
}
