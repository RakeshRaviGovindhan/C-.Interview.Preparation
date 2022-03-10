using System.Collections.Generic;
using System.Linq;

namespace CSharpInterview.Examples
{
    public static class Indexer
    {
        public static void Execute()
        {
            Customer customer = new Customer();

            var address1 = customer[691302];
            customer.PrintAddress(address1);

            var address2 = customer["Ejipura"];
            customer.PrintAddress(address2);

            var address3 = customer["Parippally", 691574];
            customer.PrintAddress(address3);
            System.Console.ReadKey();
        }


    }


    interface IIndexer
    {
        Address this[int index] { get; }
    }

    class Customer : IIndexer
    {
        List<Address> Addresses = new List<Address>();
        public Customer()
        {
            Addresses.Add(
                new Address
                {
                    HouseName = "Rajesh Sdhanam",
                    MobileNumber = 9895117191,
                    PinCode = 691302,
                    Place = "Meenambalam"
                });

            Addresses.Add(
                new Address
                {
                    HouseName = "Vilayil Veedu",
                    MobileNumber = 9895117191,
                    PinCode = 691574,
                    Place = "Parippally"
                });

            Addresses.Add(
                new Address
                {
                    HouseName = "Sneha Jyothi",
                    MobileNumber = 9895117191,
                    PinCode = 560047,
                    Place = "Ejipura"
                });
        }

        public void PrintAddress(Address address)
        {
            if (address is not null)
            {
                System.Console.WriteLine();
                System.Console.WriteLine("***********************************");
                System.Console.WriteLine("House Name    : " + address?.HouseName ?? "");
                System.Console.WriteLine("Place         : " + address?.Place ?? "");
                System.Console.WriteLine("Mobile Number : " + address?.MobileNumber ?? "");
                System.Console.WriteLine("PinCode       : " + address?.PinCode ?? "");
                System.Console.WriteLine("***********************************");                
            }
        }
        public Address this[string Place]
        {
            get => Addresses.Where(x => x.Place == Place)?.FirstOrDefault();
        }

        public Address this[int PinCode]
        {
            get => Addresses.Where(x => x.PinCode == PinCode)?.FirstOrDefault();
        }

        public Address this[string Place, int PinCode]
        {
            get => Addresses.Where(x => x.Place == Place && x.PinCode == PinCode)?.FirstOrDefault();
        }

    }

    public class Address
    {
        public string HouseName { get; set; }
        public string Place { get; set; }
        public int PinCode { get; set; }
        public long MobileNumber { get; set; }

    }
}
