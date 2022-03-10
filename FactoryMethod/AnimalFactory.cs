using System;

namespace DesignPatternsInC_Sharp.FactoryMethod
{
    public abstract class AnimalFactory
    {

        public IAnimal MakeAnimal()
        {
            Console.WriteLine("IAnimalFactory.MakeAnimal()-You cannot ignore parent rules.\n\n");            
            /*At this point, it doesn't know whether it will get a Dog or a Tiger. It will be decided by the subclasses
            i.e.DogFactory or TigerFactory. But it knows that it will Speak and it will have a preferred way of Action.
            */
            IAnimal animal = CreateAnimal();
            animal.Speak();
            animal.Action();
            return animal;
        }
        //So, the following method is acting like a factory(of creation).
        public abstract IAnimal CreateAnimal();
    }
}
