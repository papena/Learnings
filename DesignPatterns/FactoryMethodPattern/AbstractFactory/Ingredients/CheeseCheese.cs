using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.AbstractFactory.Ingredients
{
   public class CheeseCheese :ICheese
    {
        public string Name { get; set; }
        public CheeseCheese()
        {
            Name = "Chicken Cheese";
        }
    }
}
