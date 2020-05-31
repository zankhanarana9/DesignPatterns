using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternClasslibrary
{
    public abstract class PizzaStore
    {
        public abstract Pizza CreatePizza(string type);
        public Pizza OrderPizza(string type)
        {
            Pizza pizza;
            pizza = CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
    }
}
