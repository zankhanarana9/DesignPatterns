using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPatternClassLibrary.Gadgets;

namespace CommandPatternClassLibrary.Commands
{
    public class CeilingFanOffCommand :ICommand
    {
        CeilingFan CeilingFan { get; set; }
        int PreviousSpeed;
        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
            CeilingFan = ceilingFan;
        }
        public void Execute()
        {
            PreviousSpeed = CeilingFan.GetSpeed();
            
            CeilingFan.Off();
        }

        public void Undo()
        {
            if (PreviousSpeed == CeilingFan.HIGH)
            {
                CeilingFan.High();
            }
            else if (PreviousSpeed == CeilingFan.MEDIUM)
            {
                CeilingFan.Medium();
            }
            else if (PreviousSpeed == CeilingFan.LOW)
            {
                CeilingFan.Low();
            }
            else if (PreviousSpeed == CeilingFan.OFF)
            {
                CeilingFan.Off();
            }
        }
    }
}
