using System;
using System.Collections.Generic;
using System.Windows;

namespace Lab_1
{
     public static class Functions
    {
        public static double Square(double x)
        {
            return x * x;
        }

        public static double Cube(double x)
        {
            return x * x * x;
        }

        public static double SquareRoot(double x)
        {
            if(x< 0)
            {
                MessageBox.Show("Введите число больше нуля");
                return double.NaN;
            }

            return Math.Sqrt(x);
        }

        public static double SomePolynomial(double x)
        {
            return Math.Pow(x, 4) + 24 * Math.Pow(x, 3) - 5 * Math.Pow(x, 2) + 10 * x - 623;
        }

        public static double Choosing(int func, double x)
        {
            switch (func)
            {
                case 0:
                    return Square(x);
                case 1:
                    return Cube(x);
                case 2: 
                    return SquareRoot(x);
                case 3: 
                    return SomePolynomial(x);
                default:
                    throw new NotImplementedException();
            }
        }

        public static List<string> FunctionsList = new List<string>() { "x^2", "x^3", "sqrt(x)", "x^4 + 24x^3 - 5x^2 + 10x - 623" };
    }
}
