using System;

namespace FactoryMethodPattern
{
    class Program
    {
        /// <summary>
        /// Client
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var pizza = new PizzaFactory().CreatePizza("Cheese");
            pizza.OrderPizza("Cheese");

             pizza = new PizzaFactory().CreatePizza("Chicken");
            pizza.OrderPizza("Chicken");

             pizza = new PizzaFactory().CreatePizza("Veg");
            pizza.OrderPizza("Veg");

        }
    }
}
