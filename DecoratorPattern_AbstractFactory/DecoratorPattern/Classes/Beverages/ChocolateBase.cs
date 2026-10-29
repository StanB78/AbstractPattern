using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Classes.Beverages
{
    // Basis van "Chocolate milk" (die begint niet met Espresso).
    internal class ChocolateBase : Beverage
    {
        public override string GetDescription() => "Chocolate";
        public override double Cost() => 1.50;
    }
}
