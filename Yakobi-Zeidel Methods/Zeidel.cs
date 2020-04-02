using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakobi_Zeidel_Methods
{
    
    class Zeidel
    {
        static double eps = Math.Pow(10, -3);
        static int stepcount = 0;
        static double[][] A = { new double[] { 0.38, -0.05, 0.01, 0.02, 0.07 }, new double[] { 0.052, 0.595, 0, -0.04, 0.04 }, new double[] { 0.03, 0, 0.478, -0.14, 0.08 }, new double[] { -0.06, 0.126, 0, 0.47, -0.02 }, new double[] { 0.25, 0, 0.09, 0.01, 0.56 }, };
        static double[] F = { 1.84, -1.170, -0.988, 0.918, -0.490 };
        static public void Step(double[][] A, double[] F, double[] X)
        {
            bool f = false;
            double temp;
            double[] X1 = new double[5];
            for (int i = 1; i <= X.Length; i++)
            {
                for (int j = 1; j <= i - 1; j++)
                {
                    X1[i - 1] -= A[i - 1][j - 1] / A[i - 1][i - 1] * X1[j - 1];
                }
                for (int j = i + 1; j <= A.Length; j++)
                {
                    X1[i - 1] -= A[i - 1][j - 1] / A[i - 1][i - 1] * X[j - 1];
                }
                X1[i - 1] += F[i - 1] / A[i - 1][i - 1];
            }
            for (int i = 0; i < X.Length; i++)
            {
                if (Math.Abs(X1[i] - X[i]) < eps) f = true;
                else
                {
                    f = false;
                    //if (stepcount == 30)
                    //    f = true;
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
                Step(A,F,X1);
            }

        }
    }
}
