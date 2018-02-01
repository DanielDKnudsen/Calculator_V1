using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;
using NUnit.Framework;

namespace CalculatorTest
{
    [TestFixture]
    class ClearTest
    {
        private Calc _uut;

        [SetUp]
        public void SetUp()
        {
            _uut = new Calc();
        }

        [TestCase(2, 2, 0)]
        [TestCase(0, 0, 0)]
        [TestCase(-4, -5, 0)]
        [TestCase(-2, 4, 0)]
        public void Add_AccumulatorEqualsResult(double a, double b, double expectedResult)
        {
            _uut.Add(a, b);
            _uut.Clear();
            Assert.That(_uut.Accumulator == expectedResult);
        }

        [TestCase(2, 2, 0)]
        [TestCase(0, 4, 0)]
        [TestCase(4, -2, 0)]
        [TestCase(-2, -4, 0)]
        [TestCase(4, -3, 0)]
        public void Subtract_AccumulatorEqualsResult(double a, double b, double expectedResult)
        {
            _uut.Subtract(a, b);
            _uut.Clear();
            Assert.That(_uut.Accumulator == expectedResult);
        }

        [TestCase(10, 2, 0)]
        [TestCase(9, 0, 0)]
        [TestCase(-5, 2, 0)]
        [TestCase(-9, 2, 0)]
        [TestCase(100, 1, 0)]
        public void Power_AccumulatorEqualsResult(double a, double b, double expectedResult)
        {
            _uut.Power(a, b);
            _uut.Clear();
            Assert.That(_uut.Accumulator == expectedResult);
        }

        [TestCase(9, 9, 0)]
        [TestCase(-6, 12, 0)]
        [TestCase(-8, -5, 0)]
        [TestCase(24, 9, 0)]
        public void Multiply_AccumulatorEqualsResult(double a, double b, double expectedResult)
        {
            _uut.Multiply(a, b);
            _uut.Clear();
            Assert.That(_uut.Accumulator == expectedResult);
        }
    }
}
