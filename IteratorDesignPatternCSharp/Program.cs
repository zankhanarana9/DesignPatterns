using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPatternCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            PancakeHouseMenu pancake = new PancakeHouseMenu();
            DinerMenu diner = new DinerMenu();
            CafeMenu cafe = new CafeMenu();
            Waitress waitress = new Waitress(pancake, diner,cafe);
            waitress.PrintMenu();
        }
    }
}
