using AdapterDesignPatternClassLibrary.DucksAndTurkey.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPatternClassLibrary.DucksAndTurkey.Adapters
{
    public class DuckAdapter : ITurkey
    {
        IDuck duck;

        public DuckAdapter(IDuck duck)
        {
            this.duck = duck;
        }
        public void FLy()
        {
            duck.Fly();
        }

        public void Gobble()
        {
            for(int i = 0; i < 5; i++)
            {
                duck.Quack();
            }
        }
    }
}
