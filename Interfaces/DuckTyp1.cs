using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class DuckTyp1: Duck
    {
        public DuckTyp1()
        {
            flyBehavior = new FlyWithWings();
        }
    }

    public class DuckTyp2 : Duck
    {
        public DuckTyp2()
        {
            flyBehavior = new FlyNoWings();
        }
    }
}
