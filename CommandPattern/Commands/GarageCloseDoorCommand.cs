using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPatternClassLibrary.Gadgets;

namespace CommandPatternClassLibrary.Commands
{
    public class GarageCloseDoorCommand : ICommand
    {
        GarageDoor GarageDoor;
        public GarageCloseDoorCommand(GarageDoor garageDoor)
        {
            GarageDoor = garageDoor;
        }
        public void Execute()
        {
            GarageDoor.Down();
        }
        public void Undo()
        {
            GarageDoor.Up();
        }
    }
}
