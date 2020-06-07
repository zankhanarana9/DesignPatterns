using AdapterDesignPatternClassLibrary.DucksAndTurkey;
using AdapterDesignPatternClassLibrary.DucksAndTurkey.Adapters;
using AdapterDesignPatternClassLibrary.DucksAndTurkey.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPatternImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck mallardDuck = new MallardDuck();
            WildTurkey turkey = new WildTurkey();
            TestDuck(mallardDuck);
            TestTurkey(turkey);
            IDuck turkeyAdapter = new TurkeyAdapter(turkey);
            TestDuck(turkeyAdapter);
            ITurkey duckAdapter = new DuckAdapter(mallardDuck);
            TestTurkey(duckAdapter);

        }

        static void TestDuck(IDuck duck)
        {
            duck.Fly();
            duck.Quack();
        }
        static void TestTurkey(ITurkey turkey)
        {
            turkey.FLy();
            turkey.Gobble();
        }
    }

}
