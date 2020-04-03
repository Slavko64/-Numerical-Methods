using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class NewtonMethod
    {
        static double eps = 1E-8;
        static int iteration = 1;
        public void Step(double x)
        {
            Console.WriteLine(iteration++ + ") x= " + String.Format("{0:f18}", x) + " nevyazka: " + String.Format("{0:f20}", 0 - Program.f(x)));
            double dx = 1E-12;
            double x1 = x-Program.f(x)/((Program.f(x + dx) - Program.f(x)) / dx);
            
            if (Math.Abs(x1 - x) < eps)
            {
                Console.WriteLine(iteration++ + ") x= " + String.Format("{0:f18}", x1) + " nevyazka: " + String.Format("{0:f20}", 0 - Program.f(x1)));
                return;
            }
            else
                Step(x1);
        }
    }
 }

