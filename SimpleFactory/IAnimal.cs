namespace DesignPatternsInC_Sharp.SimpleFactoryPattern
{
    public interface IAnimal
    {
        void Speak();
        void Action();
        IAnimal Clone();
    }
}
