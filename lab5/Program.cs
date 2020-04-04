using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Program
    {
        static void Polynom(double[] X, double F0, double[] F, double x)
        {
            double sum = F0;

            Console.Write("L(x)="+F0);
            double product = 1;
            int j;
            for (int i = 0; i < F.Length; i++)
            {
                product = 1;
                if (F[i] > 0)
                    Console.Write("+" + String.Format("{0:f3}", F[i]));
                else
                    Console.Write(String.Format("{0:f3}", F[i]));
                for (j = 0; j <= i; j++)
                {
                    product *= x - X[j];
                    if(X[j] > 0)
                    Console.Write("(x-" +X[j] + ")");
                    else if(X[j] < 0) Console.Write("(x+" + -1*X[j] + ")");
                    else Console.Write("x");
                }

                sum += F[i] * product;
            }
            Console.WriteLine("\n\n\nf(x)=" + sum);
        }
        static double[] Interpolation(double[] X, double[] F)
        {
            double[] F1 = new double[F.Length - 1];
            double product = 1;
            for (int k = 1; k <= F1.Length; k++)
            {
                for (int j = 0; j <= k; j++)
                {
                    product = 1;
                    for (int i = 0; i <= k; i++)
                    {
                        if (i != j)
                            product *= X[j] - X[i];
                    }
                    F1[k-1] += F[j] / product;
                }
            }
            for (int i = 0; i < F1.Length; i++)
            {
                Console.WriteLine(F1[i]);
            }
            Console.WriteLine();
            return F1;
        }
        static void Main(string[] args)
        {
            double[] X = { 0, 0.1, 0.2, 0.3, 0.4, /*0.5,*/ 0.6, /*0.7,*/ 0.8, 0.9 };
            double[] FA = { 0, 0.09983, 0.19866, 0.29552, 0.38941, 0.47942, 0.56464, 0.64421, 0.71735, 0.78332};
            double[] FB = { 2, 1.95533, 1.82533, 1.62160, 1.36235, /*1.07073,*/ 0.77279, /*0.49515,*/ 0.26260, 0.09592};
            double[] FC = { 0, 0.22140, 0.49182, 0.82211, 1.2554, 1.71828, 2.32011, 3.05519, 3.95303/*, 5.04964 */};
            //double[] X = { 0, 1, 2, 3, 5 };
            //double[] F = { 1, 0, 2, 1, 4 };
            double[] F1 = Interpolation(X, FB);
            bool flag = true;
            while (flag == true) {
                Console.Write("x=");
                string a = Console.ReadLine();
                double x=0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (char.IsDigit(a[i]) == true || a[i] == ',' || a[i] == '.') a = a.Replace('.',',');
                    else flag = false;
                }
                if (flag == false || a.Length == 0) break;
                x = Convert.ToDouble(a);
                Polynom(X, FB[0], F1, x);
            }
            
        }
    }
}
