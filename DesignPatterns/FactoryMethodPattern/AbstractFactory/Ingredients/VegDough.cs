using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.AbstractFactory.Ingredients
{
    public class VegDough :IDough
    {
        public string Name { get; set; }
        public VegDough()
        {
            Name = "Veg Dough";
        }
    }
}
