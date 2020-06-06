using CommandPatternClassLibrary.Commands;
using CommandPatternClassLibrary.Gadgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatternClassLibrary
{
    public class RemoteControl
    {
        //Each slot is a command on the remote control
        ICommand[] OnCommand;
        ICommand[] OffCommand;
        ICommand UndoCommand;
        public RemoteControl()
        {
            OnCommand = new ICommand[7];
            OffCommand = new ICommand[7];
            ICommand noCommand = new NoCommand();
            for(int i =0;i <7 ; i ++)
            {
                OnCommand[i] = noCommand;
                OffCommand[i] = noCommand;
            }
            UndoCommand = noCommand;  
        }
        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand )
        {
            OnCommand[slot] = onCommand;
            OffCommand[slot] = offCommand;
        }
        public void OnButtonPressed(int slot)
        {
            OnCommand[slot].Execute();
            UndoCommand = OnCommand[slot];
        }
        public void OffButtonPressed(int slot)
        {
            OffCommand[slot].Execute();
            UndoCommand = OffCommand[slot];
        }
        public void UndoButtonWasPressed()
        {
            UndoCommand.Undo();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\n------Remote Control------");
            for (int i = 0; i < OnCommand.Length; i++)
            {
                sb.Append($"[slot \" {i} \"] {OnCommand[i].GetType()} {OffCommand[i].GetType()} {Environment.NewLine}");
        }
            return sb.ToString();
        }
    }
}
