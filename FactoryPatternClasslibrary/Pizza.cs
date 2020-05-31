using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPatternClasslibrary.Ingridients;

namespace FactoryPatternClasslibrary
{
    public abstract class Pizza
    { 
        public string Name { get; set; }
        public Dough Dough { get; set; }
        public Sauce Sauce { get; set; }
        public Cheese Cheese { get; set; }
        public Veggies[] Veggies { get; set; }

        public List<string> Toppings { get; set; }
        public Pizza()
        {
            Toppings = new List<string>();
        }

        public abstract void Prepare();

        public void Bake()
        {
            Console.WriteLine("The pizza is in the oven...");
        }
        public virtual void Cut()
        {
            Console.WriteLine("You will soon get your PI-zza!!");
        }
        public void Box()
        {
            Console.WriteLine("Right where it fits in cheesy joyfulness!!");
        }
        public override string ToString()
        {
            return $"Your {Name} pizza is ready. Enjoy the delicious meal";
        }
    }
}
