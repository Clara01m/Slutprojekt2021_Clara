using System;

namespace Projektet
{
    public class Veggies : Food
    {
          private Random generator = new Random();
        public Veggies()
        {
            setNourishment(generator.Next(3,4));
        }
    }
}
