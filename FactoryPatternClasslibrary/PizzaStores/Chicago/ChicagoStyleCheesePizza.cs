using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPatternClasslibrary.Factories;

namespace FactoryPatternClasslibrary.PizzaStores.Chicago
{
    public class ChicagoStyleCheesePizza:Pizza
    {
        PizzaIngridientFactory pizzaIngridientFactory;
        public ChicagoStyleCheesePizza(PizzaIngridientFactory pizzaIngridientFactory)
        {
            Name = "Chicago style cheese pizza";
            this.pizzaIngridientFactory = pizzaIngridientFactory;
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza in square pieces");
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing pizza {Name}");
            Sauce = pizzaIngridientFactory.CreateSauce();
            Cheese = pizzaIngridientFactory.CreateCheese();
            Dough = pizzaIngridientFactory.CreateDough();
        }
    }
}
