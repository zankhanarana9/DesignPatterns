using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPatternClassLibrary.Classes
{
    public class PopcornPopper
    {
        internal void On()
        {
            Console.WriteLine("Popper on");
        }

        internal void Pop()
        {
            Console.WriteLine("Popper popping");
        }

        internal void Off()
        {
            Console.WriteLine("Popper off");
        }
    }
}
