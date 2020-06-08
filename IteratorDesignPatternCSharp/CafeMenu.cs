using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPatternCSharp
{
    public class CafeMenu : IMenu
    {
        Hashtable menuItems = new Hashtable();
        public CafeMenu()
        {
            AddItem("Veggie burger and air fries", "Veggie burger on a whole wheat bun, lettuce, tomatoes, and fries", true, 3.99,0);
            AddItem("Soup of the day", "A cup of soup of the day, with a side salad", false, 3.69,1);
            AddItem("Burrito", "A large burrito, with whole pinto beans, salsa and guacamole", true, 4.29,2);
        }
        public void AddItem(string name, string description, bool isVegetarian, double price, int index)
        {
            MenuItem item = new MenuItem(name, description, price, isVegetarian);
            menuItems.Add(index,item);
        }

        public IEnumerator<MenuItem> CreateIterator()
        {
            return new CafeMenuIterator(menuItems);
        }
    }
}
