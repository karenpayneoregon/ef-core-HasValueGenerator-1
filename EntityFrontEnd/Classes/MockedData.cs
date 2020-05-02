using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityOperations;

namespace EntityFrontEnd.Classes
{
    public class MockedData
    {
        public static List<Customer> Customers()
        {
            var customerList = new List<Customer>()
            {
                new Customer() { CompanyName = "Alfreds Futterkiste", ContactName = "Maria Anders", ContactTypeIdentifier = 7, GenderIdentifier = 1 },
                new Customer() { CompanyName = "Die Wandernde Kuh", ContactName = "Rita Müller", ContactTypeIdentifier = 7, GenderIdentifier = 1 },
                new Customer() { CompanyName = "Chop-suey Chinese", ContactName = "Yang Wang", ContactTypeIdentifier = 7, GenderIdentifier = 2 },
                new Customer() { CompanyName = "Antonio Moreno Taquería", ContactName = "Antonio Moreno", ContactTypeIdentifier = 7, GenderIdentifier = 2 }
            };

            return customerList;
        }


    }
}
