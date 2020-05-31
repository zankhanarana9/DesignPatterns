using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternClasslibrary
{
    public class NYStyleCheesePizza: Pizza
    {
        public NYStyleCheesePizza()
        {
            Name = "NY style Sauce and cheese pizza";
            Dough = "Thin crust dough";
            Sauce = "Marinaran Sauce";

            Toppings.Add("Grated Regino cheese");
        }
    }
}
