using System;
using System.Collections.Generic;

namespace Projektet
{
    public class Food
    {
        public static Queue <Food> foodList = new Queue<Food>
        ();
        private static Random generator = new Random();
        private int nourishment;
        
        public void setNourishment(int newNourishment)
        {
            nourishment = newNourishment;
        }
        public int getNourishment()
        {
            return nourishment;
        }

       
        
    }
}
