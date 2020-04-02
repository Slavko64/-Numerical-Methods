using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Dichotomy
    {
        static double eps = Math.Pow(10, -4);
        static int iteration = 1;
        public void Step(double x0, double x1)
        {
            Console.WriteLine(iteration++ + ") xl- " + String.Format("{0:f10}", x0) + "\txx -" + String.Format("{0:f10}", (x0 + x1) / 2) + "\txr - " + String.Format("{0:f10}", x1));
            double x2 = (x0 + x1) / 2;
            double x3;
            if (Program.f(x2) * Program.f(x0) < 0)
                x3 = x0;
            else x3 = x1;
            if (Math.Abs(x3 - x2) < eps)
            {
                Console.WriteLine(iteration++ + ") x -" + String.Format("{0:f10}", (x2 + x3) / 2) + " nevyazka: " + String.Format("{0:f10}", 0 - Program.f((x2 + x3) / 2)));
            }
            else Step(x2, x3);
        }
    }
}
