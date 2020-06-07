using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePatternClassLibrary
{
    public abstract class CaffeineBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            if (CustomerWantsCondiments())
            {
                AddCondiments();
            }            
        }

        public abstract void AddCondiments();
        public abstract void Brew();
        void PourInCup()
        {
            Console.WriteLine("Pouring In cup");
        }
        void BoilWater()
        {
            Console.WriteLine("Water is boiling");
        }
        public virtual bool CustomerWantsCondiments()
        {
            return true;
        }
    }
}
