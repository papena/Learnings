using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethodPattern.AbstractFactory.Ingredients;
namespace FactoryMethodPattern.AbstractFactory
{
    class CheesePizzaIngredientsFactory : IngredientsFactory
    {
        public override ICheese Cheese()
        {
            return new CheeseCheese();
        }

        public override IDough Dough()
        {
            return new CheeseDough();
        }
    }
}
