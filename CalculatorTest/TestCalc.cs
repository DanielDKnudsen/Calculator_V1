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
    public class TestCalc
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
        public void AddTest(double a, double b, double c)
        {
            Assert.That(_uut.Add(a, b), Is.EqualTo(c));
        }
        // det her er en kommentar for at se om det virker
        [TestCase(2, 2, 0)]
        [TestCase(-2, 2, -4)]
        [TestCase(2, -2, 4)]
        [TestCase(-2, -2, 0)]
        public void SubtractTest(double a, double b, double c)
        {
            Assert.That(_uut.Subtract(a, b), Is.EqualTo(c));
        }

        [TestCase(2, 2, 4)]
        [TestCase(-2, 2, -4)]
        [TestCase(2, -2, -4)]
        [TestCase(-2, -2, 4)]
        public void MultiplyTest(double a, double b, double c)
        {
            Assert.That(_uut.Multiply(a, b), Is.EqualTo(c));
        }

        [TestCase(2, 2, 4)]
        [TestCase(-2, 2, 4)]
        [TestCase(2, -2, 0.25)]
        [TestCase(-2, -2, 0.25)]
        public void PowerTest(double a, double b, double c)
        {
            Assert.That(_uut.Power(a, b), Is.EqualTo(c));
        }
    }
}
