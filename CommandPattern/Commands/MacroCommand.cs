using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPatternClassLibrary.Gadgets;

namespace CommandPatternClassLibrary.Commands
{
    public class MacroCommand : ICommand
    {
        ICommand[] commands { get; set; }

        public MacroCommand(ICommand[] commands)
        {
            this.commands = commands;
        }
        public void Execute()
        {
            foreach(ICommand command in commands)
            {
                command.Execute();
            }
        }

        public void Undo()
        {
            foreach(ICommand command in commands)
            {
                command.Undo();
            }
        }
    }
}
