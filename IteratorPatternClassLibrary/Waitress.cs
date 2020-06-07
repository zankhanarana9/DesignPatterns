using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPatternClassLibrary
{
    public class Waitress
    {
        PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
        DinerMenu dinerMenu = new DinerMenu();

        public Waitress(PancakeHouseMenu pancake, DinerMenu diner)
        {
            pancakeHouseMenu = pancake;
            dinerMenu = diner;
        }

        public void PrintMenu()
        {
            Iterator pancakeIterator = pancakeHouseMenu.CreateIterator();
            Iterator dinerIterater = dinerMenu.CreateIterator();

            Console.WriteLine("MENU \n -----\n BREAKFAST");
            PrintMenu(pancakeIterator);
            Console.WriteLine("\nLUNCH");
            PrintMenu(dinerIterater);
        }

        void PrintMenu(Iterator itr)
        {
            while(itr.HasNext())
            {
                MenuItem menuItem = (MenuItem)itr.Next();
                Console.Write($"{menuItem.Name} , {menuItem.Price} {menuItem.Description} {Environment.NewLine}");
            }
        }
    }
}
