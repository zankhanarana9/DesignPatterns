using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternClassLibrary
{
    public class SoldState : State
    {
        GumballMachine gumballMachine;

        public  SoldState(GumballMachine gumball)
        {
            gumballMachine = gumball;
        }

        public void Dispense()
        {
            gumballMachine.ReleaseBall();
            if (gumballMachine.Count == 0)
            {
                Console.WriteLine("Oops, out of gumballs!!");
                gumballMachine.CurrentState = gumballMachine.SoldOutState;
            }
            else
            {
                gumballMachine.CurrentState = gumballMachine.NoQuarterState; 
            }
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crank");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Please wait. A gumball is on its way");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Please wait. A gumball is on its way");
        }
    }
}
