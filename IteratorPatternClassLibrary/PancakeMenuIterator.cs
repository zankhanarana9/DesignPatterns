using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPatternClassLibrary
{
    public class PancakeMenuIterator : Iterator
    {
        List<MenuItem> menuItems;
        int position = 0;
        public PancakeMenuIterator(List<MenuItem> items)
        {
            menuItems = items;
        }
        public bool HasNext()
        {
            if(position >= menuItems.Count() || menuItems[position] == null)
            {
                return false;
            }
            return true;
        }

        public object Next()
        {
            MenuItem item = menuItems[position];
            position += 1;
            return item;
        }
    }
}
