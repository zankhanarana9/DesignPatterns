using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPatternClassLibrary.Classes
{
    public class TheaterLights
    {
        internal void Dim(int v)
        {
            Console.WriteLine($"Dim the lights to {v}");
        }

        internal void On()
        {
            Console.WriteLine("Theater lights on");
        }
    }
}
