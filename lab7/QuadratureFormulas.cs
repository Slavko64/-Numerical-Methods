using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class QuadratureFormulas
    {   
        double eps =1E-5;
        public void MediumRectangles(double a, double b, int N)
        {
            double I = 0;
            double h = (b - a) / N;
            double x;
            for (int i = 1; i <= N; i++)
            {
                x = a + (i-1/2) * h;
                I += h * Program.F(x);
            }
            Console.WriteLine("Складена формула середнiх прямокутникiв I=" + I);
        }
       public void Trapeze(double a, double b, int N)
        {
            double I = 0;
            double h = (b - a) / N;
            double x = a;
            I += h / 2 * Program.F(x);
            for (int i = 1; i < N; i++)
            {
                x = a + i * h;
                I += h * Program.F(x);
            }
            x = b;
            I += h / 2 * Program.F(x);
            Console.WriteLine("Складена формула трапецiй  I = " + I);
        }

        public void Simpsons(double a, double b, int N)
        {
            double I = 0;
            double h = (b - a) / (2*N);
            double x = a;
            I += h / 3 * Program.F(x);
            for (int i = 1; i < 2*N; i++) // 2N > N, по іншому не работает
            {
                x = a + 2*i*h;
                if ((i & 1) == 1)
                    I += h / 3 * 4 * Program.F(x);
                else
                    I += h / 3 * 2 * Program.F(x);
            }
            x = a + 2*2*N*h;
            I += h / 3 * Program.F(x);
            Console.WriteLine("Складена формула Сiмпсона  I = " + I);
        }
    }
}
