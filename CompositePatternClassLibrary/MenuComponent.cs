using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternClassLibrary
{
    public abstract class MenuComponent
    {
        public virtual string Name { get;  }
        public virtual string Description { get;  }
        public virtual bool IsVegetarian { get;  }
        public virtual double Price { get; }

        public virtual void Add(MenuComponent component)
        {
            throw new NotImplementedException();
        }
        public virtual void Remove(MenuComponent component)
        {
            throw new NotImplementedException();
        }
        public virtual MenuComponent GetChild(int i)
        {
            throw new NotImplementedException();
        }
        public virtual void Print()
        {
            throw new NotImplementedException();
        }
        public abstract IEnumerator<MenuComponent> CreateIterator();
    }
}
