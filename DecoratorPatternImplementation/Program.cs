using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPatternClassLibrary;
namespace DecoratorPatternImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            Console.WriteLine($"{beverage.GetDescription()} : {beverage.Cost()}");

            //New beverage
            //Wrap it with a mocha, second mocha and then whip
            Beverage beverage2 = new Espresso();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine($"{beverage2.GetDescription()} : {beverage2.Cost()}");

        }
    }
}
