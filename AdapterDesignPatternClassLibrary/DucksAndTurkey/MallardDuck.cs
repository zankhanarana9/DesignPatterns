using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapterDesignPatternClassLibrary.DucksAndTurkey.Interfaces;


namespace AdapterDesignPatternClassLibrary.DucksAndTurkey
{
    public class MallardDuck : IDuck
    {
        public void Fly()
        {
            Console.WriteLine("I am mallard Duck. I am flying");
        }

        public void Quack()
        {
            Console.WriteLine("Quack quack");
        }
    }
}
