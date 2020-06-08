using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternClassLibrary
{
    public class MenuItem:MenuComponent
    {
        public override string  Name { get; }
        public override string Description { get; }
        public override bool IsVegetarian { get; }
        public override double Price { get; }
        IEnumerator<MenuComponent> Iterator;

        public MenuItem(string name, string description,bool isVegetarian, double price)
        {
            Name = name;
            Description = description;
            IsVegetarian = IsVegetarian;
            Price = price;
        }

        public override void Print()
        {
            Console.Write($"\n{Name}");
            if (IsVegetarian)
            {
                Console.Write("(v)");
            }
            Console.WriteLine($" {Price} {Environment.NewLine} -- {Description}");            
        }

        public override IEnumerator<MenuComponent> CreateIterator()
        {
            if(Iterator == null)
            {
                Iterator = new Composite
            }
        }
    }
}
