namespace DesignPatternsInC_Sharp.SimpleFactoryPattern
{
    public abstract class Factory
    {
        public abstract IAnimal CreateAnimal(string selectedAnimal);
    }
}
