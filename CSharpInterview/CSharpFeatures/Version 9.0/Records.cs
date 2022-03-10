using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterview.CSharpFeatures.Version_9._0
{
    public static class Records
    {
        public static void Execute()
        {
            PersonAdvanced pAdvanced = new PersonAdvanced()
            {
                FirstName = "Rakesh1",
                LastName = "Ravi1",
                PhoneNumber = "9778408078",
                Age = 35
            };
            pAdvanced.LastName = "Ravi2";

            Console.WriteLine(pAdvanced.ToString());

        }
    }

    public record PersonBasic
    {
        public string FirstName { get; init; } = "Rakesh";
        public int Age { get; init; } = 18;
    };

    public record PersonAdvanced : PersonBasic
    {
        public string LastName { get; set; } = default!;
        public string PhoneNumber { get; set; } = "9895117191";
    };
}
