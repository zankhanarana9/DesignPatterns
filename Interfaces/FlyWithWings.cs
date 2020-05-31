using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesClass
{
    public class FlyWithWings: FlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("This duck has wings");
        }
    }
}
