using System;
using System.Collections.Generic;

namespace AggregateRoute
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Customer cust = new Customer();
            cust.AddAddress(new Address());
            cust.AddAddress(new Address());
            //cust.Addressess.
        }
    }
    //class for adding objects
    class Customer
    {
        private List<Address> _addressess;

        public Customer()
        {
            _addressess = new List<Address>
                ();
        }
        public IEnumerable<Address> Addressess { get { return _addressess; } }
        public void AddAddress(Address add)
        {
            _addressess.Add(add);
        }
    }
    class Address
    {
        public string Address1 { get; set; }
    }
}
