using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calc
    {
        public double Accumulator { get; private set; }

        public double Add(double a, double b)
        {
            var result = a + b;
            Accumulator = result;
            return result;
        }

        public double Subtract(double a, double b)
        {
            var result = a - b;
            Accumulator = result;
            return result;
        }

        public double Multiply(double a, double b)
        {
            var result = a * b;
            Accumulator = result;
            return result;
        }

        public double Power(double x, double exp)
        {
            var result = Math.Pow(x, exp);
            Accumulator = result;
            return result;
        }

        public double Divide(double dividend, double dividor)
        {
            //As we are dealing with doubles, we have to manually check and throw the exception, as it is only
            //thrown automatically by dividing by int zero
            if (dividor.Equals(0))
            {
                throw new DivideByZeroException();
            }
            var result = dividend / dividor;
            return result;
        }

        public void Clear()
        {
            Accumulator = 0;
        }
    }
}
