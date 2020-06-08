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
        MenuComponent current;
        public CompositeIterator(IEnumerator<MenuComponent> iterator)
        {
            stack.Push(iterator);
        }

        public object Current => Current;

        MenuComponent IEnumerator<MenuComponent>.Current => current ;

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            if(stack.Count() < 1)
            {
                return false;
            } else
            {
                IEnumerator<MenuComponent> Iterator = stack.Peek();
                if(!Iterator.MoveNext())
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
