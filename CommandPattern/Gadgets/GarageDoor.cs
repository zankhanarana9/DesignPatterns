using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternClassLibrary.Gadgets
{
    public class GarageDoor
    {
        public void Up()
        {
            Console.WriteLine("Open the garage door");
        }

        public void Down()
        {
            Console.WriteLine("Close the garage door");
        }
        public void Stop()
        {
            Console.WriteLine("Stop the garage door at this point");
        }
        public void LightOn()
        {
            Console.WriteLine("Turn on the garage lights");
        }
        public void LightOff()
        {
            Console.WriteLine("Turn off the garage lights");
        }
    }
}
