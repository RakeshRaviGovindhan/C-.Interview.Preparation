using Builder.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.ConcreteBuilder.Concrete
{
    public class ToyABuilder : IToyBuilder
    {
        Toy toy = new Toy();
        public void SetModel()
        {
            toy.Model = "TOY A";
        }
        public void SetHead()
        {
            toy.Head = "1";
        }
        public void SetLimbs()
        {
            toy.Limbs = "4";
        }
        public void SetBody()
        {
            toy.Body = "Plastic";
        }
        public void SetLegs()
        {
            toy.Legs = "2";
        }
        public Toy GetToy()
        {
            return toy;
        }

    }
}
