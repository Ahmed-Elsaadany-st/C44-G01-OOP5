using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment05
{
    internal static class MathBasicOperation
    {


       
        public static double Sum(double x, double y)
        {
            return x + y;
        }
        public static double Divide(double numerator, double denominator)
        {
            if (denominator == 0)
                throw new DivideByZeroException("Cannot divide by zero.");

            return numerator / denominator;
        }
        public static double Sub(double x, double y)
        {
            return x - y;
        }
        public static double Multiply(double x, double y)
        {
            return x * y;
        }
    }
    
}
