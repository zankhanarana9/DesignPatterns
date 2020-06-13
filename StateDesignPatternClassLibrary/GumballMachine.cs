using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternClassLibrary
{
    public class GumballMachine
    {
        //States of the gumball machine
        public State SoldOutState { get; set; }
        public State NoQuarterState { get; set; }
        public State HasQuarterState { get; set; }
        public State SoldState { get; set; }
        public State WinnerState { get; set; }

        //instance variable keeping track of the current state
        public State CurrentState { get; set; }
        //instance variable keeping track of gumballs in the machine
        public int Count = 0;

        //Initial inventory
        public GumballMachine(int count)
        {
            SoldOutState = new SoldOutState(this);
            SoldState = new SoldState(this);
            HasQuarterState = new HasQuarterState(this);
            NoQuarterState = new NoQuarterState(this);
            WinnerState = new WinnerState(this);
            Count = count;
            if(Count >0)
            {
                CurrentState = NoQuarterState;
            }
        }
        public void EjectQuarter()
        {
            CurrentState.EjectQuarter();
        }

        public void InsertQuarter()
        {
            CurrentState.InsertQuarter();
        }

        public void TurnCrank()
        {
            CurrentState.TurnCrank();
            CurrentState.Dispense();
        }
        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if(Count != 0)
            {
                Count -= 1;
            }
        }

        public void Refill(int count)
        {
            Count = count;
            if(Count > 0)
              CurrentState = NoQuarterState;
        }
        public override string ToString()
        {
            return $"\nMighty Gumball, Inc. \n" +
                $"C# Enabled gumball model #2020\n" +
                $"Inventory: {Count} gumballs\n" +
                $"Machine is waiting for the quarter\n";
        }
    }
}
