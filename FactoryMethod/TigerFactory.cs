using DesignPatternsInC_Sharp.FactoryMethod;

namespace DesignPatternsInC_Sharp.FactoryMethod
{
    public class TigerFactory : AnimalFactory
    {
        public override IAnimal CreateAnimal()
        {
            return new Tiger();
        }
    }
}
