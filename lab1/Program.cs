using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleIterationMethod
{
    class Program
    {
        static double eps = 1E-3;
        static int stepcount = 0;
        static double[][] A = { new double[] { 0.38, -0.05, 0.01, 0.02, 0.07 }, new double[] { 0.052, 0.595, 0, -0.04, 0.04 }, new double[] { 0.03, 0, 0.478, -0.14, 0.08 }, new double[] { -0.06, 0.126, 0, 0.47, -0.02 }, new double[] { 0.25, 0, 0.09, 0.01, 0.56 }, };
        static double[] F = { 1.84, -1.170, -0.988, 0.918, -0.490 };
        static void Step(double[] X)
        {
            bool f = false;
            double temp;
            double[] X1 = new double[5];
            for (int i = 0; i < X.Length; i++)
            {
                X1[i] += X[i];
                for (int j = 0; j < X.Length; j++)
                {
                    X1[i] -= A[i][j] * X[j];
                }
                X1[i] += F[i];
            }

            for (int i = 0; i < X.Length; i++)
            {
                if (Math.Abs(X1[i] - X[i]) < eps)    f = true;
                else
                {
                    f = false;
                    break;
                }
            }
           
            if (f == true)
            {
                Console.WriteLine("X: ");
                for (int i = 0; i < X.Length; i++)
                {
                    Console.WriteLine(X1[i]);
                }

                Console.WriteLine("\n\nSteps count = " + stepcount + "\n\nVecotor r  (r = Ax-f)");
                for (int i = 0; i < A.Length; i++)
                {
                    temp = 0;
                    for (int j = 0; j < A.Length; j++)
                    {
                        temp += A[i][j] * X1[j];
                    }
                    Console.WriteLine(String.Format("{0:f10}", (temp - F[i])));
                }
            }

            else
            {
                stepcount++;
                Step(X1);
            }
        }
        static void Main(string[] args)
        {
            double[] X = new double[5];

            Random rand = new Random();
            for (int i = 0; i < X.Length; i++)
            {
                X[i] = (double)rand.Next(-10000,10000);
            }
            Step(X);
            Console.ReadLine();
        }
    }
}
