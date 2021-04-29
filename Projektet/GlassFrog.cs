using System;

namespace Projektet
{
    public class GlassFrog : Frog
    {
       public void SetHunger(int newHunger)
        {
            Hunger = Math.Max(newHunger, 0);
        } 

    }
}
