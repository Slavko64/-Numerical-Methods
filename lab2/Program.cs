using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakobi_Zeidel_Methods
{
    class Program
    {
        
        static void Main(string[] args)
            {
                double[][] A = { new double[] { 0.38, -0.05, 0.01, 0.02, 0.07 }, new double[] { 0.052, 0.595, 0, -0.04, 0.04 }, new double[] { 0.03, 0, 0.478, -0.14, 0.08 }, new double[] { -0.06, 0.126, 0, 0.47, -0.02 }, new double[] { 0.25, 0, 0.09, 0.01, 0.56 }, };
                double[] F = { 1.84, -1.170, -0.988, 0.918, -0.490 };
                double[] X = new double[5];

                Random rand = new Random();
                for (int i = 0; i < X.Length; i++)
                {
                    X[i] = (double)rand.Next(-10000, 10000);
                }
            Console.Write("Yakobi press 1, Zeidel press 2: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 1)
                Yakobi.Step(A,F,X);
            else if (n == 2)
                Zeidel.Step(A,F,X);
            else return;
            Console.Read();
            }
    }
}
