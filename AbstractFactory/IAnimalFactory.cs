namespace DesignPatternsInC_Sharp.AbstractFactory
{
    public interface IAnimalFactory
    {
        IDog GetDog();
        ITiger GetTiger();
    }
}
