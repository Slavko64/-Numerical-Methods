﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Program
    {
        static public double f(double x)
        {
            return Math.Log(2+x) - 5*Math.Pow(x,3);
        }
        static void Main(string[] args)
        {
            double x0 = 0;
            double x1 = 1;
            Dichotomy d = new Dichotomy();
            d.Step(x0, x1);
            
            Console.Read();
        }
    }
}
