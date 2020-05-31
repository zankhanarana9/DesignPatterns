using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPatternClasslibrary.Factories;
using FactoryPatternClasslibrary.Ingridients;

namespace FactoryPatternClasslibrary.PizzaStores.NY
{
    public class NYPizzaIngridientFactory : PizzaIngridientFactory
    {
        public Cheese CreateCheese()
        {
            return new ReggainoCheese();
        }

        public Dough CreateDough()
        {
            return new ThinCrustDough();
        }

        public Sauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public Veggies[] CreateVeggies()
        {
            Veggies[] veggies = { new Onions() };
            return veggies;
        }
    }
}
