using DecoratorPattern.Classes.Beverages;
using DecoratorPattern.Classes.Condiments;
using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Classes
{
    internal class CoffeeShop : BeverageStore
    {
        protected override Beverage CreateBeverage(DrinkType type)
        {
            switch (type)
            {
                case DrinkType.Espresso:       return new Espresso();
                case DrinkType.Doppio:         return Add(new Espresso(), "Espresso");
                case DrinkType.Lungo:          return Add(new Espresso(), "Water");
                case DrinkType.Macchiato:      return Add(new Espresso(), "Milk Foam");
                case DrinkType.Corretta:       return Add(new Espresso(), "Liqour");
                case DrinkType.ConPanna:       return Add(new Espresso(), "Whip");
                case DrinkType.Cappuccino:     return Add(new Espresso(), "Steamed Milk", "Milk Foam");
                case DrinkType.Americano:      return Add(new Espresso(), "Water", "Water");
                case DrinkType.CaffeLatte:     return Add(new Espresso(), "Steamed Milk", "Steamed Milk", "Milk Foam");
                case DrinkType.FlatWhite:      return Add(new Espresso(), "Steamed Milk", "Steamed Milk");
                case DrinkType.Romana:         return Add(new Espresso(), "Lemon");
                case DrinkType.Morocchino:     return Add(new Espresso(), "Chocolate", "Milk Foam");
                case DrinkType.Mocha:          return Add(new Espresso(), "Chocolate", "Steamed Milk", "Whip");
                case DrinkType.Bicerin:        return Add(new Espresso(), "Black Chocolate", "White Chocolate", "Whip");
                case DrinkType.Breve:          return Add(new Espresso(), "Milk Foam", "Half Milk");
                case DrinkType.RafCoffee:      return Add(new Espresso(), "Vanilla Sugar", "Cream");
                case DrinkType.MeadRaf:        return Add(new Espresso(), "Honey", "Cream");
                case DrinkType.Galao:          return Add(new Espresso(), "Milk Foam", "Milk Foam");
                case DrinkType.CaffeAffogato:  return Add(new Espresso(), "Espresso", "Ice cream");
                case DrinkType.ViennaCoffee:   return Add(new Espresso(), "Espresso", "Whip", "Whip");
                case DrinkType.Glace:          return Add(new Espresso(), "Ice cream");
                case DrinkType.ChocolateMilk:  return Add(new ChocolateBase(), "Milk", "Milk");
                case DrinkType.DemiCreme:      return Add(new Espresso(), "Espresso", "Cream", "Cream");
                case DrinkType.LatteMacchiato: return Add(new Espresso(), "Steamed Milk", "Steamed Milk", "Milk Foam");
                case DrinkType.Freddo:         return Add(new Espresso(), "Liqour", "Ice");
                case DrinkType.Frappuccino:    return Add(new Espresso(), "Ice", "Steamed Milk", "Whip");
                case DrinkType.CaramelFrappuccino: return Add(new Espresso(), "Ice", "Steamed Milk", "Cream", "Syrup");
                case DrinkType.Frappe:         return Add(new Espresso(), "Steamed Milk", "Steamed Milk", "Ice cream");
                case DrinkType.IrishCoffee:    return Add(new Espresso(), "Espresso", "Whiskey", "Whip");
                default: throw new ArgumentOutOfRangeException(nameof(type));
            }
        }

        // Wikkelt het drankje in een decorator per ingrediënt.
        private static Beverage Add(Beverage beverage, params string[] condiments)
        {
            foreach (string name in condiments)
            {
                beverage = new Condiment(beverage, name);
            }
            return beverage;
        }
    }
}
