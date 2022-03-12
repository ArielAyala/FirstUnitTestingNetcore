using System;
using System.Collections.Generic;
using System.Text;

namespace FirstUnitTestingNetcore
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class CollectionsSample
    {
        public static Customer GetCustomer(Customer[] customers, int index)
        {
            return customers[index];
        }
    }


}
