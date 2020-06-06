using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternClassLibrary.Gadgets
{
    public class Light
    { 
        public void On()
        {
            Console.WriteLine("Turn on the lights");
        }
        public void Off()
        {
            Console.WriteLine("Turn off the lights");
        }
    }
}
