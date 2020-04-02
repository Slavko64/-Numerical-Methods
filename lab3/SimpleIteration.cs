using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class SimpleIteration
    {

        static double eps = Math.Pow(10, -8);
        static int iteration = 1;
        double f(double x) => Math.Pow(Math.Log(2 + x) / 5, 1 / 3f);
        public void Step(double x)
        {

            Console.WriteLine(iteration++ + ") x= " + String.Format("{0:f10}", x) + " nevyazka: " + String.Format("{0:f10}", 0-Program.f(x)));
            double x1 = this.f(x);
            if (Math.Abs(x1 - x) < eps)
            {
                Console.WriteLine(iteration++ + ") x= " + String.Format("{0:f10}", x1) + " nevyazka: " + String.Format("{0:f10}", 0 - Program.f(x1)));
                return;
            }
            else
                Step(x1);
        }
    }
}
