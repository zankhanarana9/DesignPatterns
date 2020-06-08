using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPatternCSharp
{
    public class DinerMenu : IMenu
    {
        static readonly int MAX_ITEMS = 6;
        int numberOfItems = 0;
        MenuItem[] menuItems;

        public DinerMenu()
        {
            menuItems = new MenuItem[MAX_ITEMS];
            AddItem("Vegetarian BLT", "(Fakin')Bacon with lettuce and tomato on whole wheat", true, 2.99);
            AddItem("BLT", "Bacon with lettuce and tomato on whole wheat", false, 2.99);
            AddItem("Soup of the day", "Soup of the day, with a side of potato salad", false, 3.29);
            AddItem("Hot dog", "A hot dog, with saurkaut, relish, onions, topped with cheese", false, 3.05);
        }       

        public void AddItem(string name, string description, bool isVegetarian, double price)
        {
            MenuItem item = new MenuItem(name, description, price, isVegetarian);
            if(numberOfItems > MAX_ITEMS)
            {
                Console.WriteLine("Sorry, menu is full! Can't add item to the menu");
            } else
            {
                menuItems[numberOfItems++] = item;
            }
        }

        public IEnumerator<MenuItem> CreateIterator()
        {
            return new DinerMenuIterator(menuItems);
        }
    }
}
