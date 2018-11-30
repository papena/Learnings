using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust1 = new Customer();
            cust1.Add(new Address() { Address1 = "test0", Type = "A" });
            cust1.Add(new Address() { Address1 = "test0", Type = "B" });
            cust1.Add(new Address() { Address1 = "test0", Type = "C" });
            //cust1.Addresses = new System.Collections.Generic.List<Address>();
            //cust1.Addresses.Add(new Address() { Address1 = "test0", Type = "A" });
            //cust1.Addresses.Add(new Address() { Address1 = "test0", Type = "A" });
            //cust1.Addresses.Add(new Address() { Address1 = "test0", Type = "A" });
            //cust1.Addresses.Add(new Address() { Address1 = "test0", Type = "A" });
            foreach (var item in cust1.Addresses)
            {
                Console.WriteLine("Address:" + item.Address1 + "Type:" + item.Type);
            }
            Console.ReadLine();
        }
    }
}
