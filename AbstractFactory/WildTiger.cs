using System;

namespace DesignPatternsInC_Sharp.AbstractFactory
{
    class WildTiger : ITiger
    {

        public void Speak()
        {
            Console.WriteLine("Wild Tiger says: Halum.\n\n");
        }
        public void Action()
        {
            Console.WriteLine("Wild Tigers prefer hunting in jungles.\n\n");
        }
    }
}
