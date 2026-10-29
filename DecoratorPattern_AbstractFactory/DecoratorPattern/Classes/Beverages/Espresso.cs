using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Classes.Beverages
{
    internal class Espresso : Beverage
    {
        public override string GetDescription() => "Espresso";
        public override double Cost() => 1.99;
    }
}
