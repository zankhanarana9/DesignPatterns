using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapterDesignPatternClassLibrary.DucksAndTurkey.Interfaces;

namespace AdapterDesignPatternClassLibrary.DucksAndTurkey 
{
    public class WildTurkey : ITurkey
    {
        public void FLy()
        {
            Console.WriteLine("I am turkey. I can fly short distance");
        }

        public void Gobble()
        {
            Console.WriteLine("Gobble gobble!");
        }
    }
}
