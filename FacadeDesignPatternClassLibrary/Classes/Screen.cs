using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPatternClassLibrary.Classes
{
    public class Screen
    {
        internal void Down()
        {
            Console.WriteLine("Screen down");
        }

        internal void Up()
        {
            Console.WriteLine("Screen up");
        }
    }
}
