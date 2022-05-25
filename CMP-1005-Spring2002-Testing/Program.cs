using System;
using Calculator_Logic;

namespace CMP_1005_Spring2002_Testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            double x = calc.Add(1,1);

            Console.WriteLine(x);
        }
    }
}
