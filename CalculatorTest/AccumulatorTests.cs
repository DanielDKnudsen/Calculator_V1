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
    class AccumulatorTests
    {
        private Calc _uut;

        [SetUp]
        public void Setup()
        {
            _uut = new Calc();
        }

        [TestCase(2, 2, 4)]
        [TestCase(0, 0, 0)]
        [TestCase(-4, -5, -9)]
        [TestCase(-2, 4, 2)]
        public void Add_AccumulatorEqualsResult(double a, double b, double expectedResult)
        {
            _uut.Add(a, b);
            Assert.That(_uut.Accumulator == expectedResult);
        }

        [TestCase(2, 2, 0)]
        [TestCase(0, 4, -4)]
        [TestCase(4, -2, 6)]
        [TestCase(-2, -4, 2)]
        [TestCase(4, -3, 7)]
        public void Subtract_AccumulatorEqualsResult(double a, double b, double expectedResult)
        {
            _uut.Subtract(a, b);
            Assert.That(_uut.Accumulator == expectedResult);
        }

        [TestCase(10, 2, 100)]
        [TestCase(9, 0, 1)]
        [TestCase(-5, 2, 25)]
        [TestCase(-9, 2, 81)]
        [TestCase(100, 1, 100)]
        public void Power_AccumulatorEqualsResult(double a, double b, double expectedResult)
        {
            _uut.Power(a, b);
            Assert.That(_uut.Accumulator == expectedResult);
        }

        [TestCase(9, 9, 81)]
        [TestCase(-6, 12, -72)]
        [TestCase(-8, -5, 40)]
        [TestCase(24, 9, 216)]
        public void Multiply_AccumulatorEqualsResult(double a, double b, double expectedResult)
        {
            _uut.Multiply(a, b);
            Assert.That(_uut.Accumulator == expectedResult);
        }
    }
}
