using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethodPattern.AbstractFactory.Ingredients;
namespace FactoryMethodPattern.AbstractFactory
{
    class ChickenPizzaIngredientsFactory : IngredientsFactory
    {
        public override ICheese Cheese()
        {
            return new ChickenCheese();
        }

        public override IDough Dough()
        {
            return new ChickenDough();
        }
    }
}
