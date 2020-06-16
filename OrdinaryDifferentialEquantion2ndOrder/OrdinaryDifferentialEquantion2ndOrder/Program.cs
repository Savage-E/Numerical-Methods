using System;

namespace OrdinaryDifferentialEquantion2ndOrder
{
    internal class Program
    {
        private static double yy(double x)
        {
            double res = (1/ 16)* Math.Exp(4 * x) + 8 * x - 3;
            return res;

        }

        private static double f(double x, double y)
        {
            return Math.Exp(4*x) ;
        }

        private static void Main(string[] args)
        {
            double a, b;
            double h;
            int n;
            a = 0;
            b = 1;
            h = 0.00001;
            n = (int)Math.Ceiling((b - a) / h) + 1;

            double[] x = new double[n];
            double[] y = new double[n];
            double[] u = new double[n];

            x[0] = 0;
            y[0] = 1;
            u[0] = 2;

            for (int i = 0; i < n - 1; i++)
            {
                x[i + 1] = x[i] + h;
                y[i + 1] = y[i] + h * u[i];
                u[i + 1] = u[i] + h * f(x[i], y[i]);
                Console.WriteLine("Xi={0}  Yi={1}  YY={2}\n", x[i + 1], y[i + 1], yy(x[i + 1]));
            }

            Console.Read();
        }
    }
}