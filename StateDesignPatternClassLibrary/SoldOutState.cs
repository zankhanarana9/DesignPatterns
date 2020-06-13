using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternClassLibrary
{
    public class SoldOutState : State
    {
        GumballMachine gumballMachine;
        public SoldOutState(GumballMachine gumball)
        {
            gumballMachine = gumball;
        }
        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry, you can't eject. you ahven't inserted a quarter");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert a quarter. The machine is sold out");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned but there are no gumballs");
        }
    }
}
