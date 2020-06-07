using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePatternClassLibrary
{
    public class Tea : CaffeineBeverage
    {
        public override void AddCondiments()
        {
            Console.WriteLine("Add lemon");
        }

        public override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }              
    }
}
