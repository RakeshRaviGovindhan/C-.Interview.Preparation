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
            Factory simpleFactory = new AnimalConcrete();

            #region The code region that will vary based on userspreference

            Console.WriteLine("Factory can accept (DOG for Dog, TIGER for Tiger)\n\n");
            Console.WriteLine("Creating Dog Animal\n\n");
            preferredType = simpleFactory.CreateAnimal("DOG");

            #endregion

            Console.WriteLine("Dog Animal created, you will get Dog Features\n\n");

            #region The codes that do not change frequently

            preferredType.Speak();
            preferredType.Action();

            #endregion

            Console.WriteLine("Creating Tiger Animal\n\n");
            preferredType = simpleFactory.CreateAnimal("TIGER");


            Console.WriteLine("Tiger Animal created, you will get Tiger Features\n\n");

            #region The codes that do not change frequently

            preferredType.Speak();
            preferredType.Action();

            #endregion

            #endregion
        }


    }
}
