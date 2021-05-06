using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Additional.Classes
{
    public class CalcService
    {
        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Sub(double a, double b)
        {
            return a - b;
        }
        public double Mul(double a, double b)
        {
            return a * b;
        }
        public double Clear(double a, double b)
        {
            return a=b=0;
        }
        public double Div(double a, double b)
        {
            if (b != 0)
                return a / b;
            else
                return 0;
        }
    }
}
