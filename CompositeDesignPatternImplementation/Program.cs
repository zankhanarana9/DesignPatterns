using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompositePatternClassLibrary;

namespace CompositeDesignPatternImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuComponent PancakeMenu = new Menu("PANCAKE HOUSE MENU", "Breakfast");
            MenuComponent DinerMenu = new Menu("DINER MENU", "Lunch");
            MenuComponent CafeMenu = new Menu("CAFE MENU", "Dinner");
            MenuComponent DessertMenu = new Menu("DESSERT MENU", "Desserts");

            MenuComponent AllMeus = new Menu("ALL MENUS", "All menus combined");
            
            AllMeus.Add(PancakeMenu);
            AllMeus.Add(DinerMenu);
            AllMeus.Add(CafeMenu);

            DinerMenu.Add(new MenuItem("Pasta", "Sphagetti with Marinara sauce, and a slice of sourdough bread", true, 3.89));
            DessertMenu.Add(new MenuItem("Apple pie", "Apple pie with a flaky crust, topped with vanilla ice cream", true, 1.59));
            PancakeMenu.Add(new MenuItem("Pancake", "Pancake with berries", false, 4.69));
            PancakeMenu.Add(new MenuItem("Blueberry pancakes(v)", "Pancakes made with fresh blueberries", true, 3.49));
            CafeMenu.Add(new MenuItem("Coffee", "Fresh brewed starbuzz coffee", true, 2.99));
            CafeMenu.Add(new MenuItem("Tea", "Chai Tea with fresh basil leaf", true, 2.99));
            DinerMenu.Add(DessertMenu);

            Waitress waitress = new Waitress(AllMeus);
            waitress.PrintVegetarianMenu();
        }
    }
}
