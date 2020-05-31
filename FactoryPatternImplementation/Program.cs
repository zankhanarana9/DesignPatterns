using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPatternClasslibrary;

namespace FactoryPatternImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyPizzaStore = new NYStylePizzaStore();
            PizzaStore ChicagoPizzaStore = new ChicagoPizzaStore();

            Pizza pizza = nyPizzaStore.OrderPizza("Cheese");
            Console.WriteLine($"Ethan orderd {pizza.Name}");

            Pizza pizza2 = ChicagoPizzaStore.OrderPizza("Cheese");
            Console.WriteLine($"Joel orderd {pizza2.Name}");
        }
    }
}
