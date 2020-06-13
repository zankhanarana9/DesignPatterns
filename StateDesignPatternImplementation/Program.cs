using StateDesignPatternClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPatternImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            GumballMachine gumballMachine = new GumballMachine(5);
            Console.WriteLine(gumballMachine.ToString());
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            
            Console.WriteLine(gumballMachine.ToString());

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            Console.WriteLine(gumballMachine.ToString());
            //Console.ReadKey();
        }
    }
}
