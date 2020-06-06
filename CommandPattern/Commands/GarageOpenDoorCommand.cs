using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPatternClassLibrary.Gadgets;

namespace CommandPatternClassLibrary.Commands
{
    public class GarageOpenDoorCommand : ICommand
    {
        GarageDoor GarageDoor { get; set; }
        
        public GarageOpenDoorCommand(GarageDoor garageDoor)
        {
            GarageDoor = garageDoor;
        }
        public void Execute()
        {
            GarageDoor.Up();
        }
        public void Undo()
        {
            GarageDoor.Down();
        }
    }
}
