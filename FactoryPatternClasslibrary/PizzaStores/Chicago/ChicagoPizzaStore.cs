using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPatternClasslibrary.Factories;

namespace FactoryPatternClasslibrary.PizzaStores.Chicago
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            PizzaIngridientFactory pizzaIngridientFactory =
                new ChicagoPizzaIngridientFactory();
            if (type == "Cheese")
            {
                pizza = new ChicagoStyleCheesePizza(pizzaIngridientFactory);
            }
            return pizza;
        }
    }
}
