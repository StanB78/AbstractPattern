namespace DecoratorPattern.Interfaces
{
    // Zelfde opzet als PizzaStore: OrderBeverage() vraagt de Factory Method om een drankje.
    internal abstract class BeverageStore
    {
        public Beverage OrderBeverage(DrinkType type)
        {
            Beverage beverage = CreateBeverage(type);
            Console.WriteLine("Preparing " + type);
            return beverage;
        }

        protected abstract Beverage CreateBeverage(DrinkType type);
    }
}
