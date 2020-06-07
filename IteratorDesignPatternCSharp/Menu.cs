using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPatternCSharp
{
    public interface Menu
    {
        IEnumerator<MenuItem> CreateIterator();
    }
}
