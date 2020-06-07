﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPatternClassLibrary
{
    public class DinerMenuIterator : Iterator
    {
        MenuItem[] items;
        int position = 0;

        public DinerMenuIterator(MenuItem[] items)
        {
            this.items = items;
        }
        public bool HasNext()
        {
            if(position >= items.Length || items[position] ==null)
            {
                return false;
            }
            return true;
        }

        public object Next()
        {
            MenuItem menuItem = items[position];
            position += 1;
            return menuItem;
        }
    }
}
