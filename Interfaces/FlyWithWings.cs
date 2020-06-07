using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class FlyWithWings: FlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("This duck has wings");
        }
    }
}
