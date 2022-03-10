using System;

namespace DesignPatternsInC_Sharp.AbstractFactory
{
    class PetDog : IDog
    {
        public void Speak()
        {
            Console.WriteLine("Pet Dog says: Bow-Wow.\n\n");
        }
        public void Action()
        {
            Console.WriteLine("Pet Dogs prefer to stay at home.\n\n");
        }
    }
}
