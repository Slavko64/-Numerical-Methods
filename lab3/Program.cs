using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Program
    {
       static double eps = Math.Pow(10, -4);
        static int iteration = 1;
        static public double f(double x)
        {
            return Math.Log(2+x) - 5*Math.Pow(x,3);
        }
        static void Main(string[] args)
        {
            double x0 = 0;
            double x1 = 1;
            SimpleIteration simple = new SimpleIteration();
            //simple.Step(x0);
            Dichotomy d = new Dichotomy();
            d.Step(x0, x1);
            Console.Read();
        }
    }
}
