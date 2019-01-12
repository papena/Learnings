using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethodPattern.AbstractFactory.Ingredients;
namespace FactoryMethodPattern.AbstractFactory
{
    class VegPizzaIngredientsFactory : IngredientsFactory
    {
        public override ICheese Cheese()
        {
            return new VegCheese();
        }

        public override IDough Dough()
        {
            return new VegDough();
        }
    }
}
