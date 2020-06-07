using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPatternClassLibrary.Classes
{
    public class Projector
    {
        internal void WideScreenMode()
        {
            Console.WriteLine("Widescreen mode on");
        }

        internal void On()
        {
            Console.WriteLine("Projector turned on");
        }

        internal void Off()
        {
            Console.WriteLine("Projector turned off");
        }
    }
}
