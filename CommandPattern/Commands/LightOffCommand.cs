    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPatternClassLibrary.Gadgets;
namespace CommandPatternClassLibrary.Commands
{
    public class LightOffCommand : ICommand
    {
        Light Light;
        public LightOffCommand(Light light)
        {
            Light = light;
        }
        public void Execute()
        {
            Light.Off();
        }
        public void Undo()
        {
            Light.On();
        }
    }
}
