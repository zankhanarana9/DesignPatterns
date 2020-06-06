using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPatternClassLibrary;
using CommandPatternClassLibrary.Gadgets;
using CommandPatternClassLibrary.Commands;

namespace CommandPatternImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControl Remote = new RemoteControl();
            Light Light = new Light();
            LightOnCommand LightOn = new LightOnCommand(Light);
            LightOffCommand LightOff = new LightOffCommand(Light);

            CeilingFan Fan = new CeilingFan("Living room");
            CeilingFanHighCommand FanHigh = new CeilingFanHighCommand(Fan);
            CeilingFanLowCommand FanLow = new CeilingFanLowCommand(Fan);
            CeilingFanMediumCommand FanMedium = new CeilingFanMediumCommand(Fan);
            CeilingFanOffCommand FanOff = new CeilingFanOffCommand(Fan);

            GarageDoor GarageDoor = new GarageDoor();
            GarageCloseDoorCommand GarageCloseDoor = new GarageCloseDoorCommand(GarageDoor);
            GarageOpenDoorCommand GarageOpenDoor = new GarageOpenDoorCommand(GarageDoor);

            ICommand[] OnCommands = { LightOn, FanHigh, GarageOpenDoor };
            ICommand[] OffCommands = { LightOff, FanOff, GarageCloseDoor };
            MacroCommand MacroOnCommand = new MacroCommand(OnCommands);
            MacroCommand MacroOffCommand = new MacroCommand(OffCommands);

            Remote.SetCommand(0, LightOn, LightOff);           
            Remote.SetCommand(1, FanMedium, FanOff);
            Remote.SetCommand(2, FanHigh, FanOff);
            Remote.SetCommand(3, MacroOnCommand, MacroOnCommand);

            Console.WriteLine(Remote.ToString());

            Remote.OnButtonPressed(3);
            Remote.UndoButtonWasPressed();
            //Remote.OnButtonPressed(0);
            //Remote.UndoButtonWasPressed();
            //Remote.OnButtonPressed(1);
            //Remote.OffButtonPressed(1);
            //Console.WriteLine(Remote.ToString());
            //Remote.UndoButtonWasPressed();
            //Remote.OnButtonPressed(2);
            //Console.WriteLine(Remote.ToString());
            //Remote.UndoButtonWasPressed();
        }
    }
}
