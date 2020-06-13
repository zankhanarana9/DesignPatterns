using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternClassLibrary
{
    public class HasQuarterState : State
    {
        GumballMachine gumballMachine;
        Random rnd = new Random(DateTime.Now.Millisecond);
        public HasQuarterState(GumballMachine gumball)
        {
            gumballMachine = gumball;
        }
        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert another quarter");
        }
        public void EjectQuarter()
        {
            gumballMachine.CurrentState = gumballMachine.NoQuarterState;
            Console.WriteLine("Quarter returned");
        }
        public void TurnCrank()
        {
            Console.WriteLine("You turned..");
            int winner = rnd.Next(10);
            if(winner == 0 && gumballMachine.Count > 1)
            {
                gumballMachine.CurrentState = gumballMachine.WinnerState;
            } else
            {
                gumballMachine.CurrentState = gumballMachine.SoldState;
            }            
        }
        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }    
    }
}
