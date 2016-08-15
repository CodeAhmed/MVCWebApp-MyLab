using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWebApp_MyExp.Models
{
    public class Person
    {
        public string Name { get; set; }
        public List<Address> Addresses { get; set; }

        public Person()
        {
            Name = "George";

            var newYork = new Address
            {
                City = "NY",
                Country = "USA",
                PostalCode = "10021",
                Street = "34 Vosges street"
            };

            var paris = new Address
            {
                City = "Paris",
                Country = "France",
                PostalCode = "75001",
                Street = "13 Leclerc street"
            };

            var bruxelles = new Address
            {
                City = "Bruxelles",
                Country = "Belgium",
                PostalCode = "65478",
                Street = "01 Garden Street"
            };

            Addresses = new List<Address> { newYork, paris, bruxelles };
        }
    }
}