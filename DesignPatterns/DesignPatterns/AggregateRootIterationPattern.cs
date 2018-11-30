using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns
{
    //public class Customer
    //{
    //    public string CustomerName { get; set; }
    //    public DateTime DateofBirth { get; set; }

    //    public List<Address> Addresses { get; set; }

    //}
    public class Customer
    {
        public Customer()
        {
            _addresses = new List<Address>();
        }
        public string CustomerName { get; set; }
        public DateTime DateofBirth { get; set; }

        private List<Address> _addresses { get; set; } 
        public IEnumerable<Address> Addresses // Step 3 :- To browse use enumerator
        {
            get { return _addresses; }
        }
        public void Add(Address address)
        {
            var exists = _addresses.Any(x => x.Type == address.Type);
            if (exists)
            {
                throw new Exception();
            }
            _addresses.Add(address);
        }
    }
    public class Address
    {
        public string Address1 { get; set; }
        public string Type { get; set; }
    }
}
