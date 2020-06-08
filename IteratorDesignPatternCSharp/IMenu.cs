using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPatternCSharp
{
    public interface IMenu
    {
        IEnumerator<MenuItem> CreateIterator();
    }
}
