using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternClassLibrary
{
    public class NoQuarterState : State
    {
        GumballMachine gumballMachine;

        public NoQuarterState(GumballMachine gumball)
        {
            gumballMachine = gumball;
        }
        public void Dispense()
        {
            Console.WriteLine("You need to pay first");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You haven't inserted the quarter");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You inserted the quarter");
            gumballMachine.CurrentState = gumballMachine.HasQuarterState;
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned but there's no quarter");
        }
    }
}
