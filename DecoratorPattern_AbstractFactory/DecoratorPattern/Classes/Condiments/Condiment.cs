using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Classes.Condiments
{
    // Een generieke decorator: per ingrediënt geef je alleen naam en prijs mee.
    internal class Condiment : Beverage
    {
        private readonly Beverage beverage;
        private readonly string name;
        private readonly double cost;

        public Condiment(Beverage beverage, string name, double cost = 0.50)
        {
            this.beverage = beverage;
            this.name = name;
            this.cost = cost;
        }

        public override string GetDescription() => beverage.GetDescription() + ", " + name;
        public override double Cost() => beverage.Cost() + cost;
    }
}
