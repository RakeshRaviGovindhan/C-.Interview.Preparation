using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterview.CSharpFeatures.Version_9._0
{
    internal class InitOnlySetters
    {
        Product p = new Product()
        {
            ProductID = 10,
            ProductName = "colgate",
            ProductPrice = 32.50
        };
    }

    class Product
    {
        public long ProductID { get; init; }
        public string ProductName { get; init; }
        public double ProductPrice { get; init; }
    }
}
