﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //BaseClass bc = new BaseClass();
            //DerivedClass dc = new DerivedClass();
            BaseClass bcdc = new DerivedClass();

            //bc.Method1();
            //dc.Method1();
            //dc.Method2();
            bcdc.Method1();
            bcdc.Method2();
            
        }
        // Output:  
        // Base - Method1  
        // Base - Method1  
        // Derived - Method2  
        // Base - Method1  
    }
    class BaseClass
    {
        public void Method1()
        {
            Console.WriteLine("Base - Method1");
        }
        public void Method2()
        {
            Console.WriteLine("Base- Method2");
        }
    }

    class DerivedClass : BaseClass
    {
        public new void Method2()
        {
            Console.WriteLine("Derived - Method2");
        }
    }
}
