using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class Program
    {
        static public double F(double x) => 1 / (3 + 2 * Math.Cos(x));//1 / x;
        static void Main(string[] args)
        {
            double a = 0, b = Math.PI;
            int N = 100000;
            QuadratureFormulas formulas = new QuadratureFormulas();
            formulas.MediumRectangles(a, b, N);
            formulas.Trapeze(a, b, N);
            formulas.Simpsons(a, b, N);
            Console.ReadLine();
        }
    }
}
