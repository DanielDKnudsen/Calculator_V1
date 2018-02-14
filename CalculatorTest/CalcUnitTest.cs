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
    public class CalcUnitTest
    {
        private Calc _uut;

        [SetUp]
        public void SetUp()
        {
            _uut = new Calc();
        }

        [TestCase(2, 2, 4)]
        [TestCase(-2, 2, 0)]
        [TestCase(2, -2, 0)]
        [TestCase(-2, -2, -4)]
        [TestCase(-2, -2.5, -4.5)]
        public void Add_AddVariousNumbers_ReturnsCorrectSum(double a, double b, double c)
        {
            Assert.That(_uut.Add(a, b), Is.EqualTo(c));
        }
        
        [TestCase(2, 2, 0)]
        [TestCase(-2, 2, -4)]
        [TestCase(2, -2, 4)]
        [TestCase(-2, -2, 0)]
        public void Subtract_SubtractVariousNumbers_ReturnsCorrectResult(double a, double b, double c)
        {
            Assert.That(_uut.Subtract(a, b), Is.EqualTo(c));
        }

        [TestCase(2, 2, 4)]
        [TestCase(-2, 2, -4)]
        [TestCase(2, -2, -4)]
        [TestCase(-2, -2, 4)]
        public void Multiply_MultiplyVariousNumbers_ReturnsCorrectResult(double a, double b, double c)
        {
            Assert.That(_uut.Multiply(a, b), Is.EqualTo(c));
        }

        [TestCase(2, 2, 4)]
        [TestCase(-2, 3, -8)]
        [TestCase(2, -2, 0.25)]
        [TestCase(-2, -2, 0.25)]
        public void Power_RaiseToVariousPowers_ReturnsCorrectResult(double a, double b, double c)
        {
            Assert.That(_uut.Power(a, b), Is.EqualTo(c));
        }

        [TestCase(10, 1, 10)]
        [TestCase(5, 5, 1)]
        [TestCase(-2, 2, -1)]
        [TestCase(4.5, 2, 2.25)]
        [TestCase(-2, -2, 1)]
        [TestCase(9, 4, 2.25)]
        [TestCase(10.4, 5.2, 2)]
        public void Divide_DivideVariousNumbers_ReturnsCorrectResult(double a, double b, double expectedResult)
        {
            Assert.That(_uut.Divide(a, b), Is.EqualTo(expectedResult));
        }

        [TestCase(5, 0)]
        public void Divide_TryToDivideByZero_ThrowsDivideByZeroException(double dividend, double dividor)
        {
            //var ex = Assert.Throws<DivideByZeroException>(() => _uut.Divide(dividend, dividor));
            //Assert.That(ex, Is.EqualTo(typeof(DivideByZeroException)));

            Assert.Throws(typeof(DivideByZeroException), () => _uut.Divide(dividend, dividor));
        }
    }
}
