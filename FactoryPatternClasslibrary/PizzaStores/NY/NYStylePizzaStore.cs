using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPatternClasslibrary.Factories;

namespace FactoryPatternClasslibrary.PizzaStores.NY
{
    public class NYStylePizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            PizzaIngridientFactory pizzaIngridientFactory =
                new NYPizzaIngridientFactory();
            if(type=="Cheese")
            {
                pizza= new NYStyleCheesePizza(pizzaIngridientFactory);
            } 
            return pizza;
        }        
    }
}
