using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPatternClassLibrary.Gadgets;

namespace CommandPatternClassLibrary.Commands
{
    public class LightOnCommand :ICommand
    {
        Light Light { get; set; }
        public LightOnCommand(Light light)
        {
            Light = light;
        }
        public void Execute()
        {
            Light.On();
        }

        public void Undo()
        {
            Light.Off();
        }
    }
}
