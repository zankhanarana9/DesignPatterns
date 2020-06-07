using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPatternClassLibrary
{
    public class PancakeHouseMenu
    {
        List<MenuItem> MenuItems;
        public PancakeHouseMenu()
        {
            MenuItems = new List<MenuItem>();
            AddItem("K&B's Pancake breakfast", "Pancakes with eggs, and toast", true, 2.99);
            AddItem("Regular Pancake breakfast", "Pancakes with fried eggs, sausage", true, 2.99);
            AddItem("Blueberry Pancake breakfast", "Pancakes with blueberries", true, 3.49);
            AddItem("Waffles", "Waffles, with your choice of blueberries or strawberries", true, 3.59);
        }

        public void AddItem(string name, string description, bool isVegetarian, double price)
        {
            MenuItem item = new MenuItem(name, description, price, isVegetarian);
            MenuItems.Add(item);
        }

        public Iterator CreateIterator()
        {
            return new PancakeMenuIterator(MenuItems);
        }
    }
}
