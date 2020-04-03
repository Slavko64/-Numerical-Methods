using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Program
    {
        static public double f(double x)
        {
            return Math.Log(2 + x) - 5 * Math.Pow(x, 3);
        }
        static void Main(string[] args)
        {
            Dichotomy d = new Dichotomy();
            double x0 = -100;
            double x1 = 100;
            d.Step(x0, x1);
            Console.ReadLine();
        }
    }
}
