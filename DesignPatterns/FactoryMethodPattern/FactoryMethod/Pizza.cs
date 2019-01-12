using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    abstract class Pizza
    {
        public void OrderPizza(string type)
        {
            this.create(type);
            Bake(type);
            Cut(type);
            Box(type);
        }
        internal void Bake(string type)
        {
            Console.WriteLine("Baking "+ type + "at 135 degree Celsius for 20 minutes");
        }
        internal void Cut(string type)
        {
            Console.WriteLine("Cutting "+ type + "into diagonal pieces");
        }
        internal void Box(string type)
        {
            Console.WriteLine("Putting "+ type + "pizza in coloured box");
            Console.WriteLine("--------------------------------------------------------------");
        }
        public abstract void create(string type);
    }
}
