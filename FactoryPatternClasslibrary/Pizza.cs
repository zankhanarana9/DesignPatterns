using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternClasslibrary
{
    public class Pizza
    { 
        public string Name { get; set; }
        public string Dough { get; set; }
        public string Sauce { get; set; }
        public List<string> Toppings { get; set; }
        public Pizza()
        {
            Toppings = new List<string>();
        }
        public void Prepare()
        {
            Console.WriteLine("Preparing the pizza...");
            Console.WriteLine("Adding toppings: ");
            foreach(string topping in Toppings)
            {
                Console.WriteLine($" {topping}");
            }
        }
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
    }
}
