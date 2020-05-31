using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPatternClasslibrary;
using FactoryPatternClasslibrary.PizzaStores;
using FactoryPatternClasslibrary.Factories;

namespace FactoryPatternImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyPizzaStore = 
                new FactoryPatternClasslibrary.PizzaStores.NY.NYStylePizzaStore();
            PizzaStore ChicagoPizzaStore = 
                new FactoryPatternClasslibrary.PizzaStores.Chicago.ChicagoPizzaStore();

            Pizza pizza = nyPizzaStore.OrderPizza("Cheese");
            Console.WriteLine($"Ethan orderd {pizza.Name}");

            Pizza pizza2 = ChicagoPizzaStore.OrderPizza("Cheese");
            Console.WriteLine($"Joel orderd {pizza2.Name}");
        }
    }
}
