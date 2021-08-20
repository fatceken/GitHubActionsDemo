using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubActionsDemoApp
{
    public class SampleMath
    {
        public static double Add(double x, double y)
        {
            return x + y;
        }

        public static double Substract(double x, double y)
        {
            return x - y;
        }

        public static double Multiply(double x, double y)
        {
            return x * y;
        }

        public static double Divide(double x, double y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException();
            }

            return x / y;
        }

    }
}
