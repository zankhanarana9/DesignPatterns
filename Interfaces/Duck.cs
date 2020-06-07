using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Duck
    {
        public string Ducktype { get; set; }
        public FlyBehaviour flyBehavior { get; set; }

        public void PerformFly()
        {
            flyBehavior.Fly();
        }
    }
}
