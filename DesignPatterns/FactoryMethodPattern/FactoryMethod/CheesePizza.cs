using FactoryMethodPattern.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    class CheesePizza : Pizza
    {
        private readonly IngredientsFactory _ingredientsFactory;
        public  CheesePizza(IngredientsFactory ingredients)
        {
            _ingredientsFactory = ingredients;
        }
        public override void create(string type)
        {
            Console.WriteLine("This is " + type + " Pizza");
            Console.WriteLine("Creating with Cheese " + _ingredientsFactory.Cheese().Name);
            Console.WriteLine("Creating with Dough " + _ingredientsFactory.Dough().Name);
            
        }
    }
}
