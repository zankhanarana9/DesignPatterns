using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternClasslibrary
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            if (type == "Cheese")
            {
                return new ChicagoStyleCheesePizza();
            }
            else
            {
                return null;
            }
        }
    }
}
