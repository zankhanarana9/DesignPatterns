using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternClassLibrary.Gadgets
{
    public class CeilingFan
    {
        public static readonly int HIGH = 3;
        public static readonly int MEDIUM = 2;
        public static readonly int LOW = 1;
        public static readonly int OFF = 0;
        public string Location;
        int Speed;

        public CeilingFan(string location)
        {
            this.Location = location;
            Speed = OFF;
        }

        public void Medium()
        {
            Speed = MEDIUM;
            Console.WriteLine("Fan is switched  on to medium");
        }
        public void Low()
        {
            Speed = LOW;
            Console.WriteLine("Fan is switched  on to low");
        }
        public void High()
        {
            Speed = HIGH;
            Console.WriteLine("Fan is switched  on to high");
        }
        public void Off()
        {
            Speed = OFF;
            Console.WriteLine("Fan is switched  off");
        }

        public int GetSpeed()
        {
            return Speed;
        }
    }
}
