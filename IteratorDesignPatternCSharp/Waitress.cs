using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPatternCSharp
{
    public class Waitress
    {
        IMenu pancakeHouseMenu = new PancakeHouseMenu();
        IMenu dinerMenu = new DinerMenu();
        IMenu cafeMenu = new CafeMenu();

        public Waitress(PancakeHouseMenu pancake, DinerMenu diner, CafeMenu cafe)
        {
            pancakeHouseMenu = pancake;
            dinerMenu = diner;
            cafeMenu = cafe;
        }

        public void PrintMenu()
        {
            IEnumerator<MenuItem> pancakeIterator = pancakeHouseMenu.CreateIterator();
            IEnumerator<MenuItem> dinerIterater = dinerMenu.CreateIterator();
            IEnumerator<MenuItem> cafeIterator = cafeMenu.CreateIterator();
            Console.WriteLine("MENU \n-----\nBREAKFAST");
            PrintMenu(pancakeIterator);
            Console.WriteLine("\nLUNCH");
            PrintMenu(dinerIterater);
            Console.WriteLine("\nDinner");
            PrintMenu(cafeIterator);
        }

        void PrintMenu(IEnumerator<MenuItem> itr)
        {
            while(itr.MoveNext())
            {
                MenuItem menuItem = (MenuItem)itr.Current;
                Console.Write($"{menuItem.Name} , {menuItem.Price} {menuItem.Description} {Environment.NewLine}");
            }
        }
    }
}
