using Builder.ConcreteBuilder.Concrete;
using Builder.Director;
using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Builder Design Pattern");

            Console.WriteLine("-------------------------------List Of Toys--------------------------------------------");
            var toyACreator = new ToyCreator(new ToyABuilder());
            toyACreator.CreateToy();
            toyACreator.GetToy();
            var toyBCreator = new ToyCreator(new ToyBBuilder());
            toyBCreator.CreateToy();
            toyBCreator.GetToy();
        }
    }
}
