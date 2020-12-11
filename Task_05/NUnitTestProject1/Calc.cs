using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestProject1
{
    static class Calc
    {
        static public double Plus(double term1, double term2)
        {
            return term1 + term2;
        }

        static public double Minus(double minuend, double subtrahend)
        {
            return minuend - subtrahend;
        }

        static public double Division(double dividend, double divider)
        {
            if (divider == 0)
                return 0;
            return dividend / divider;
        }

        static public double Multiplication(double multiplier1, double multiplier2)
        {
            return multiplier1 * multiplier2;
        }
    }
}
