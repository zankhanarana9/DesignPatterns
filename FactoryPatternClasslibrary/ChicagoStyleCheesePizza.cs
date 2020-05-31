using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternClasslibrary
{
    public class ChicagoStyleCheesePizza:Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            Name = "Chicago style cheese pizza";
            Dough = "Thick Crust dough";
            Sauce = "Plum Tomato Sauce";
            Toppings.Add("Shredded Mozzarella cheese");

        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza in square pieces");
        }
    }
}
