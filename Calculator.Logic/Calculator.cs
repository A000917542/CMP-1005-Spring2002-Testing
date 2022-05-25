using System;

namespace Calculator_Logic
{
    public class Calculator
    {
        public double Add(double left, double right)
        {
            return left + right;
        }

        public double Divide(double left, double right)
        {
            if (right != 0)
            {
                return left / right;
            }
            else
            {
                throw new DivideByZeroException();
            }
            
        }
    }
}
