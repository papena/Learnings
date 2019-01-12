using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.AbstractFactory.Ingredients
{
    public class CheeseDough :IDough
    {
        public string Name { get; set; }
        public CheeseDough()
        {
            Name = "Cheese Dough";
        }
    }
}
