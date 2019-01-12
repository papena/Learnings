using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.AbstractFactory.Ingredients
{
    public class VegCheese : ICheese
    {
        public string Name { get; set; }
        public VegCheese()
        {
            Name = "VegCheese";
        }
    }
}
