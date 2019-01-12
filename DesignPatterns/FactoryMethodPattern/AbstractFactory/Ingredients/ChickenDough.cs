using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.AbstractFactory.Ingredients
{
    public class ChickenDough :IDough
    {
        public string Name { get; set; }
        public ChickenDough()
        {
            Name = "Chicken Dough";
        }
    }
}
