using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPatternClasslibrary.Ingridients;
using FactoryPatternClasslibrary.Factories;

namespace FactoryPatternClasslibrary.PizzaStores.Chicago
{
    class ChicagoPizzaIngridientFactory : PizzaIngridientFactory
    {
        public Cheese CreateCheese()
        {
            return new MozzarellaCheese();
        }

        public Dough CreateDough()
        {
            return new ThickCrustDough();
        }

        public Sauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public Veggies[] CreateVeggies()
        {
            Veggies[] veggies = { new Spinach() };
            return veggies;
        }
    }
}
