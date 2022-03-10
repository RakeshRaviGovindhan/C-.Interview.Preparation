using DesignPatternsInC_Sharp.FactoryMethod;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("*** Factory Method Design Pattern Demo ***\n\n");

            AnimalFactory dogFactory = new DogFactory();
            AnimalFactory tigerFactory = new TigerFactory();

            Console.WriteLine("Dog Factory can create only Dog Animals!\n\n");

            IAnimal aDog = dogFactory.MakeAnimal();

            Console.WriteLine("Tiger Factory can create only Tiger Animals!\n\n");

            IAnimal aTiger = tigerFactory.MakeAnimal();

        }
    }
}
