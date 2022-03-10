using System;

namespace DesignPatternsInC_Sharp.AbstractFactory
{
    class PetTiger : ITiger
    {

        public void Speak()
        {
            Console.WriteLine("Pet Tiger says: Halum.\n\n");
        }
        public void Action()
        {
            Console.WriteLine("Pet Tigers play in an animal circus.\n\n");
        }
    }
}
