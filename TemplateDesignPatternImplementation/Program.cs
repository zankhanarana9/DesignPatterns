using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplatePatternClassLibrary;

namespace TemplateDesignPatternImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Tea tea = new Tea();
            Coffee coffee = new Coffee();
            Console.WriteLine("Making tea...");
            tea.PrepareRecipe();
            Console.WriteLine("Making coffee...");
            coffee.PrepareRecipe();

        }
    }
}
