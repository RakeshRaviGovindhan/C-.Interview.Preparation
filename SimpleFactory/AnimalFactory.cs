namespace DesignPatternsInC_Sharp.SimpleFactoryPattern
{
    public abstract class AnimalFactory
    {
        public abstract IAnimal CreateAnimal(int selectedAnimal);
    }
}
