using Builder.ConcreteBuilder;
using Builder.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Director
{
    public class ToyCreator
    {
        private IToyBuilder _toyBuilder;
        public ToyCreator(IToyBuilder toyBuilder)
        {
            _toyBuilder = toyBuilder;
        }
        public void CreateToy()
        {
            _toyBuilder.SetModel();
            _toyBuilder.SetHead();
            _toyBuilder.SetLimbs();
            _toyBuilder.SetBody();
            _toyBuilder.SetLegs();
        }
        public Toy GetToy()
        {
            return _toyBuilder.GetToy();
        }
    }
}
