using DesignPatternsInC_Sharp.AbstractFactory;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** TechWebDots: Factory Method Design Pattern Demo***\n\n");

            Console.WriteLine("*** TechWebDots: Making a wild tiger through WildAnimalFactory ***\n\n");
            //Making a wild tiger through WildAnimalFactory
            IAnimalFactory wildAnimalFactory = new WildAnimalFactory();
            ITiger wildTiger = wildAnimalFactory.GetTiger();
            wildTiger.Speak();
            wildTiger.Action();

            Console.WriteLine("*** TechWebDots: Making a pet dog through PetAnimalFactory ***\n\n");
            //Making a pet dog through PetAnimalFactory
            IAnimalFactory petAnimalFactory = new PetAnimalFactory();
            IDog petDog = petAnimalFactory.GetDog();
            petDog.Speak();
            petDog.Action();
        }
    }
}
