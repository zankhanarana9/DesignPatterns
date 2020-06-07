using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPatternCSharp
{
    public class DinerMenuIterator : IEnumerator<MenuItem>
    {
        MenuItem[] items;
        int position = 0;
        MenuItem currentItem;
        public DinerMenuIterator(MenuItem[] items)
        {
            this.items = items;
        }

        public MenuItem Current => currentItem;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        public bool MoveNext()
        {
            if (position >= items.Length || items[position] == null)
            {
                return false;
            }
            currentItem = items[position];
            position += 1;
            return true;
        }

        public object Next()
        {
            MenuItem menuItem = items[position];
            position += 1;
            return menuItem;
        }

        public void Reset()
        {
            position = 0;
        }
    }
}
