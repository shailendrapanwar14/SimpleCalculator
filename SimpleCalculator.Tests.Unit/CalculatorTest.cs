using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests.Unit
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void AddTwoNumbers()
        {
            double result = Calculator.Calculate(1, 2, "+");
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void AddTwoNumbersWithoutSymbolic()
        {
            double result = Calculator.Calculate(1, 2, "add");
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void SubtractTwoNumbers()
        {
            double result = Calculator.Calculate(3, 2, "-");
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void SubtractTwoNumbersWithSmallerNumberFisrt()
        {
            double result = Calculator.Calculate(2, 3, "-");
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void SubtractTwoNumbersWithoutSymbolic()
        {
            double result = Calculator.Calculate(3, 2, "subtract");
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void SubtractTwoNumbersWithSmallerNumberFisrtWithoutSymbolic()
        {
            double result = Calculator.Calculate(2, 3, "subtract");
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void MultiplyTwoNumbers()
        {
            double result = Calculator.Calculate(1, 2, "*");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void MultiplyTwoNumbersWithoutSymbolic()
        {
            double result = Calculator.Calculate(1, 2, "multiply");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void DivideTwoNumbers()
        {
            double result = Calculator.Calculate(4, 2, "/");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void DivideTwoNumberWithSmallerNumberFirst()
        {
            double result = Calculator.Calculate(2, 4, "/");
            Assert.AreEqual(2, result);
        }


        [TestMethod]
        public void DivideTwoNumbersWithoutSymbolic()
        {
            double result = Calculator.Calculate(4, 2, "divide");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void DivideTwoNumberWithSmallerNumberFirstWithoutSymbolic()
        {
            double result = Calculator.Calculate(2, 4, "divide");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void ConfirmInvalidSymbolicOperationsAreNotSupported_Completely()
        {
            double result = Calculator.Calculate(5, 10, "%");
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void ConfirmInvalidWithoutSymbolicOperationsAreNotSupported_Completely()
        {
            double result = Calculator.Calculate(5, 10, "percentile");
        }
    }
}

