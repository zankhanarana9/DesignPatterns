using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPatternClassLibrary.Classes
{
    public class DvdPlayer
    {
        internal void On()
        {
            Console.WriteLine("DvdPlayer turned on");
        }

        internal void Play(string movie)
        {
            Console.WriteLine($"Playing the movie {movie}");
        }

        internal void Stop()
        {
            Console.WriteLine("DvdPlayer stopped");
        }

        internal void Eject()
        {
            Console.WriteLine("Eject the disk");
        }

        internal void Off()
        {
            Console.WriteLine("DvdPlayer off");
        }
    }
}
