using System;

namespace Projektet
{
    public class insects : Food
    {
        private Random generator = new Random();
        public insects()
        {
            setNourishment(generator.Next(2,5));
        }
    }
}
