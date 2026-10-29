using DecoratorPattern.Classes;
using DecoratorPattern.Interfaces;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BeverageStore store = new CoffeeShop();

            // Een drankje bestellen
            Beverage cappuccino = store.OrderBeverage(DrinkType.Cappuccino);
            Console.WriteLine(cappuccino.GetDescription() + " = " + cappuccino.Cost().ToString("0.00"));
            Console.WriteLine();
                
            // Alle drankjes uit de tabel bestellen
            foreach (DrinkType type in Enum.GetValues(typeof(DrinkType)))
            {
                Beverage beverage = store.OrderBeverage(type);
                Console.WriteLine(beverage.GetDescription() + " = " + beverage.Cost().ToString("0.00"));
            }
            Console.ReadKey();
        }
    }
}