namespace DesignPatternsInC_Sharp.FactoryMethod
{
    public class DogFactory: AnimalFactory
    {
        public override IAnimal CreateAnimal()
        {
            //Creating a Dog
            return new Dog();
        }
    }
}
