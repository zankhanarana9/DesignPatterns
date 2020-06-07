using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPatternCSharp
{
    public class Waitress
    {
        Menu pancakeHouseMenu = new PancakeHouseMenu();
        DinerMenu dinerMenu = new DinerMenu();

        public Waitress(PancakeHouseMenu pancake, DinerMenu diner)
        {
            pancakeHouseMenu = pancake;
            dinerMenu = diner;
        }

        public void PrintMenu()
        {
            IEnumerator<MenuItem> pancakeIterator = pancakeHouseMenu.CreateIterator();
            IEnumerator<MenuItem> dinerIterater = dinerMenu.CreateIterator();

            Console.WriteLine("MENU \n-----\nBREAKFAST");
            PrintMenu(pancakeIterator);
            Console.WriteLine("\nLUNCH");
            PrintMenu(dinerIterater);
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
