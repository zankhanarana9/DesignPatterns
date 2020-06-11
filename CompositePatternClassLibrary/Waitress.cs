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
        public void PrintVegetarianMenu()
        {
            IEnumerator<MenuComponent> enumerator = AllMenus.CreateIterator();
            Console.WriteLine("\nVEGETARIAN MENU-----");
            while(enumerator.MoveNext())
            {
                MenuComponent menuComponent = (MenuComponent)enumerator.Current;
                try
                {
                    if (menuComponent.IsVegetarian)
                    {
                        menuComponent.Print();
                    }
                }
                catch (InvalidOperationException ex) { }
            }
        }
    }
}
