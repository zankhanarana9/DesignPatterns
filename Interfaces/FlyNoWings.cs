using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesClass
{
    public class FlyNoWings:FlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("This duck cannot fly");
        }
    }
}
