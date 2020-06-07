using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePatternClassLibrary
{
    public class Coffee : CaffeineBeverage
    {
        public override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }

        public override void Brew()
        {
            Console.WriteLine("Dripping the coffee through the filter");
        }
        public override bool CustomerWantsCondiments()
        {
            string condiments = "y";
            //string condiments = GetUserInput()
            if(condiments.ToLower().StartsWith("y"))
            {
                return true;
            }
            return false;
        }
    }
}
