using DesignPatternsInC_Sharp.SimpleFactoryPattern;
using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Comment all except this region to check Simple Factory Pattern Demo & Include SimpleFactoryPattern namaspace only

            Console.WriteLine("*** Simple Factory Pattern Demo***\n\n");

            IAnimal preferredType = null;
            AnimalFactory simpleFactory = new AnimalConcrete();

                #region The code region that will vary based on userspreference

                Console.WriteLine("Factory can accept (0 for Dog, 1 for Tiger)\n\n");
                Console.WriteLine("Creating Dog Animal - 0\n\n");
                preferredType = simpleFactory.CreateAnimal(0);

                #endregion

                Console.WriteLine("Dog Animal created, you will get Dog Features\n\n");

                #region The codes that do not change frequently

                preferredType.Speak();
                preferredType.Action();

                #endregion

                Console.WriteLine("Creating Tiger Animal - 1\n\n");
                preferredType = simpleFactory.CreateAnimal(1);


                Console.WriteLine("Tiger Animal created, you will get Tiger Features\n\n");

                #region The codes that do not change frequently

                preferredType.Speak();
                preferredType.Action();

                #endregion

            #endregion
        }
    }
}
