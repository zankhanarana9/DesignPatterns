using AdapterDesignPatternClassLibrary.DucksAndTurkey.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPatternClassLibrary.DucksAndTurkey.Adapters
{
    public class TurkeyAdapter : IDuck
    {
        WildTurkey turkey;

        public TurkeyAdapter(WildTurkey turkey)
        {
            this.turkey = turkey;
        }

        public void Fly()
        {
            turkey.FLy();
        }

        public void Quack()
        {
            for(int i =0;i < 5; i++)
            {
                turkey.Gobble();
            }
        }
    }
}
