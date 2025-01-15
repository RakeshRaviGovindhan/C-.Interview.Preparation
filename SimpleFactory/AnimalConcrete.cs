using System;
using System.Collections.Generic;
using System.ComponentModel;
using Unity;

namespace DesignPatternsInC_Sharp.SimpleFactoryPattern
{
    public class AnimalConcrete : Factory
    {
        // Replacing if with polymorphism pattern (RIP pattern)
        //Dictionary<string, IAnimal> Animals = new Dictionary<string, IAnimal>();

        // You can you unity application block to - RIP pattern
        IUnityContainer container = new UnityContainer();
        public AnimalConcrete()
        {
            //Animals.Add("DOG", new Dog());
            //Animals.Add("TIGER", new Dog());
            container.RegisterType<IAnimal, Dog>("DOG");
            container.RegisterType<IAnimal, Tiger>("TIGER");            
        }
        public override IAnimal CreateAnimal(string Type)
        {
            IAnimal intendedAnimal = null;

            /*
            switch (input)
            {
                case 0:
                    intendedAnimal = new Dog();
                    break;
                case 1:
                    intendedAnimal = new Tiger();
                    break;
                default:
                    //WriteAsync("Choice must be either 0 or 1");                    
                    //We'll throw a runtime exception for any other choices.
                    throw new ApplicationException(String.Format(" Unknown Animal cannot be instantiated"));
            }
            */

            // Replacing if with polymorphism pattern
            //intendedAnimal = Animals[Type].Clone();

            intendedAnimal = container.Resolve<IAnimal>(Type);
            return intendedAnimal;
        }
    }
}
