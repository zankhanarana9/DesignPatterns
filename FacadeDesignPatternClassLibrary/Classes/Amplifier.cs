using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPatternClassLibrary.Classes
{
    public class Amplifier
    {
        internal void On()
        {
            Console.WriteLine("Amplifier on");
        }

        internal void SetDvd(DvdPlayer dvd)
        {
            Console.WriteLine("Dvd is ready");
        }

        internal void SetVolume(int v)
        {
            Console.WriteLine("Volume increased to " + v);
        }

        internal void SetSurroundSound()
        {
            Console.WriteLine("Surroned sound set");
        }

        internal void Off()
        {
            Console.WriteLine("Amplifier turned off");
        }
    }
}
