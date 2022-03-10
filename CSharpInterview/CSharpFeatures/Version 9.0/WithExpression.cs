using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterview.CSharpFeatures.Version_9._0
{
    internal class WithExpression
    {
        public static void Execute()
        {
            PersonB pAdvanced = new PersonB()
            {
                FirstName = "Rakesh1",
                LastName = "Ravi1",
                PhoneNumber = "9778408078",
                Age = 35
            };

            PersonB personB = pAdvanced with { PhoneNumber = "9895117191" };

            Console.WriteLine(personB.ToString());

        }
    }

    public record PersonB
    {
        public string FirstName { get; init; } = "Rakesh";
        public string LastName { get; set; } = default!;
        public string PhoneNumber { get; set; } = "9895117191";
        public int Age { get; init; } = 18;
    };

}
