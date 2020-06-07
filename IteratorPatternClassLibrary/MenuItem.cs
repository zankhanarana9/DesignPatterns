using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPatternClassLibrary
{
    public class MenuItem
    {
        public string Name { get; }
        public string Description { get; }
        public double Price { get; }
        public bool IsVegetarian { get; }

        public MenuItem(string name, string description, double price, bool isVegetarian)
        {
            Name = name;
            Description = description;
            Price = price;
            IsVegetarian = isVegetarian;
        }
    }
}
