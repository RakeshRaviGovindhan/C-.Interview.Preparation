using System;

namespace DesignPatternsInC_Sharp.FactoryMethod
{
    public class Tiger : IAnimal
    {

        public void Speak()
        {
            Console.WriteLine("Tiger says: Halum...\n");
        }
        public void Action()
        {
            Console.WriteLine("Tigers prefer hunting...\n\n");
        }
    }
}
