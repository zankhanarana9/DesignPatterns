using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternClassLibrary
{
    public class Waitress
    {
        MenuComponent AllMenus;
        public Waitress(MenuComponent allMenus)
        {
            AllMenus = allMenus;
        }
        public void PrintMenu()
        {
            AllMenus.Print();
        }
    }
}
