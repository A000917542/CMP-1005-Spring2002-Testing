using Calculator_Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculator_Test
{
    [TestClass]
    public class UnitTest1
    {
        Calculator calc;

        [TestInitialize]
        public void Instantiate()
        {
            calc = new Calculator();
        }

        [TestCleanup]
        public void TearDown()
        {
            calc = null;
        }

        [TestMethod]
        public void CalculatorClassIsInstantiable()
        {
            Assert.IsNotNull(calc);
        }

        [TestMethod]
        [DataRow(2, 1, 1)]
        [DataRow(3, 2, 1)]
        [DataRow(5, 3, 2)]
        public void CalculatorCanAddTwoPositiveNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Add(left, right));
        }

        [TestMethod]
        public void CalculatorThrowsExceptionWhenDividingByZero()
        {
            Assert.ThrowsException<DivideByZeroException>(() => { calc.Divide(9, 0); });
        }

        [TestMethod]
        public void CalculatorDividesPositiveNumbersWithDenominatorGreaterThenZero()
        {
            Assert.AreEqual(9, calc.Divide(9, 1));
        }
    }
}
