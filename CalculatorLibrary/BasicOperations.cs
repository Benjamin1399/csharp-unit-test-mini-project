using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLibrary
{
    public class BasicOperations
    {
        public double AddTwoNumbers(double a, double b)
        {
            return a + b;
        }

        public double SubtractTwoNumbers(double a, double b)
        {
            return a - b;
        }

        public double MultiplyTwoNumbers(double a, double b)
        {
            return a * b;
        }

        public double DivideTwoNumbers(double a, double b)
        {
            double output = 0;

            if (b != 0)
            {
                output = a / b;
            }

            return output;
        }
    }
}
