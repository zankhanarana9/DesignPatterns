using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPatternCSharp
{
    public interface Iterator
    {
        bool HasNext();
        object Next();
    }
}
