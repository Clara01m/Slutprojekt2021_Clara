using System;

namespace Projektet
{
    public class GoliathFrog : Frog
    {
        public void SetHunger(int newHunger)
        {
            Hunger = Math.Max(newHunger, 0);
        }

    }
}
