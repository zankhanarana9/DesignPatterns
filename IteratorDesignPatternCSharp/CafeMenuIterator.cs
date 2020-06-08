using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPatternCSharp
{
    public class CafeMenuIterator : IEnumerator<MenuItem>
    {
        Hashtable menuItems;
        int position;
        MenuItem currentItem;
        public CafeMenuIterator(Hashtable items)
        {
            menuItems = items;
        }
        public MenuItem Current => currentItem;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public bool MoveNext()
        {
            if (position >= menuItems.Count)
            {
                return false;
            }
            currentItem = (MenuItem)menuItems[position];
            position += 1;
            return true;
        }

        public void Reset()
        {
            position = 0;
        }
    }
}
