using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPatternClasslibrary.Factories;

namespace FactoryPatternClasslibrary.PizzaStores.NY
{
    public class NYStyleCheesePizza: Pizza
    {
        PizzaIngridientFactory PizzaIngridientFactory;

        public NYStyleCheesePizza(PizzaIngridientFactory ingridientFactory)
        {
            Name = "NY style Sauce and cheese pizza";
            this.PizzaIngridientFactory = ingridientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing Pizza {Name}");
            Dough = PizzaIngridientFactory.CreateDough();
            Cheese = PizzaIngridientFactory.CreateCheese();
            Sauce = PizzaIngridientFactory.CreateSauce();   
        }
    }
}
