namespace FactoryMethodPattern.AbstractFactory
{
    abstract class IngredientsFactory
    {
        public abstract ICheese Cheese();
        public abstract IDough Dough();
    }
}
