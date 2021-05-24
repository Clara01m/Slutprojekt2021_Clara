using System;

namespace Projektet
{
    public class Food
    {
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
