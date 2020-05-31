using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternClassLibrary
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            //Field inherited from Beverage
            description = "Espresso";
        }
        public override double Cost()
        {
            return 1.99;
        }
    }
}
