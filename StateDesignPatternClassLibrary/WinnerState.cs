using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternClassLibrary
{
    public class WinnerState : State
    {
        private GumballMachine gumballMachine;

        public WinnerState(GumballMachine gumball)
        {
            gumballMachine = gumball;
        }

        public void Dispense()
        {
            Console.WriteLine("YOU'RE A WINNER! YOU GET TWO GUMBALLS FOR YOUR QUARTER");
            gumballMachine.ReleaseBall();
            if(gumballMachine.Count == 0)
            {
                gumballMachine.CurrentState = gumballMachine.SoldOutState;
            } else
            {
                gumballMachine.ReleaseBall();
                if(gumballMachine.Count > 0 )
                {
                    gumballMachine.CurrentState = gumballMachine.NoQuarterState;
                } else
                {
                    Console.WriteLine("Oops! out of gumballs!");
                    gumballMachine.CurrentState = gumballMachine.SoldOutState;
                }
            }
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crank");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Please wait, we're already giving you a gumball");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning twice doesn't get you another gumball!");
        }
    }
}
