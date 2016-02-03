using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            Calculator calc = new Calculator();
            int number1 = 4;
            int number2 = 6;
            int expected = 10;

            int actual = calc.Add(number1, number2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            Calculator calc = new Calculator();
            int number1 = 4;
            int number2 = 6;
            int expected = 24;

            int actual = calc.Multiply(number1, number2);

            Assert.AreEqual(expected, actual);
        }
    }
}