using FactoryMethodPattern.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    class PizzaFactory
    {
        public Pizza CreatePizza(string PizzaType)
        {
            Pizza pizza=null;
            IngredientsFactory ingredients = null;
            if (PizzaType=="Cheese")
            {
                ingredients = new CheesePizzaIngredientsFactory();
                pizza = new CheesePizza(ingredients);
            }
            else if (PizzaType == "Chicken")
            {
                ingredients = new ChickenPizzaIngredientsFactory();
                pizza = new ChickenPizza(ingredients);
            }
            else if (PizzaType == "Veg")
            {
                ingredients = new VegPizzaIngredientsFactory();
                pizza = new VegPizza(ingredients);
            }
            return pizza;
        }
    }
}
