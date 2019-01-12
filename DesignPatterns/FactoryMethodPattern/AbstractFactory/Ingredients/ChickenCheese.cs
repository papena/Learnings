using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.AbstractFactory.Ingredients
{
    public class ChickenCheese : ICheese
    {
        public string Name { get; set; }
        public ChickenCheese()
        {
            Name = "Chicken Cheese";
        }
    }
}
