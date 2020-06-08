using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPatternCSharp
{
    public class AlternatingDinerMenuIterator : IEnumerator<MenuItem>
    {
        MenuItem[] menuItems;
        int position;
        MenuItem currentItem;
        public AlternatingDinerMenuIterator(MenuItem[] items)
        {
            menuItems = items;
            DateTime dateTime = DateTime.Now;
            position = (int)dateTime.DayOfWeek % 2;
        }
        public MenuItem Current => currentItem;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public bool MoveNext()
        {
            if (position >= menuItems.Length || menuItems[position] == null)
            {
                return false;
            }            
            position += 2;
            return true;
        }

        public void Reset()
        {
            position = 0;
        }
    }
}
