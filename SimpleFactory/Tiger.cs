using System;

namespace DesignPatternsInC_Sharp.SimpleFactoryPattern
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
        public IAnimal Clone()
        {
            return (IAnimal)this.MemberwiseClone();
        }
    }
}
