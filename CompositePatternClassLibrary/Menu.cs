using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternClassLibrary
{
    public class Menu :MenuComponent
    {
        List<MenuComponent> MenuComponents = new List<MenuComponent>();
        public override string Name { get; }
        public override string Description { get; }
        IEnumerator<MenuComponent> Enumerator;

        public Menu(string name, string description)
        {
            Name = name;
            Description = description;
        }
        public override void Add(MenuComponent component)
        {
            MenuComponents.Add(component);
        }
        public override void Remove(MenuComponent component)
        {
            MenuComponents.Remove(component);
        }
        public override MenuComponent GetChild(int i)
        {
            return MenuComponents[i];
        }
        public override void Print()
        {
            Console.Write($"\n{Name}, {Description}\n --------------");
            IEnumerator<MenuComponent> Iterator = MenuComponents.GetEnumerator();
            while (Iterator.MoveNext())
            {
                MenuComponent component = (MenuComponent)Iterator.Current;
                component.Print();
            }
        }

        public override IEnumerator<MenuComponent> CreateIterator()
        {
            if(Enumerator == null)
            {
                Enumerator = new CompositeIterator(MenuComponents.GetEnumerator());
            }
            return Enumerator;
        }
    }
}
