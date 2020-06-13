using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternClassLibrary
{ 
    public class CompositeIterator : IEnumerator<MenuComponent>
    {
        Stack<IEnumerator<MenuComponent>> stack = new Stack<IEnumerator<MenuComponent>>();
        public CompositeIterator(IEnumerator<MenuComponent> iterator)
        {
            stack.Push(iterator);
        }

        public MenuComponent Current
        {
            get
            {
                IEnumerator<MenuComponent> enumerator = stack.Peek();
                MenuComponent menuComponent = (MenuComponent)enumerator.Current;
                if (menuComponent.GetType() == typeof(Menu))
                {
                    stack.Push(menuComponent.CreateIterator());
                }
                return menuComponent;
            }
        }

        object IEnumerator.Current => Current ;

        MenuComponent IEnumerator<MenuComponent>.Current => Current;

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            if(stack.Count() == 0)
            {
                return false;
            } else
            {
                IEnumerator<MenuComponent> Enumerator = stack.Peek();
                if(!Enumerator.MoveNext())
                {
                    stack.Pop();
                    return MoveNext();
                }else
                {
                    return true;
                }
            }
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
