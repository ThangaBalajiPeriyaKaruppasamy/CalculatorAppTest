using NUnit.Framework;
using CalculatorTests;
namespace CalculatorTests
{
    [TestFixture]
    public class CalculatorUnitTests
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void Add_PassCase()
        {
            Assert.AreEqual(3, calculator.Add(1, 2));
        }

        [Test]
        public void Add_FailCase()
        {
            Assert.AreEqual(4, calculator.Add(1, 2));
        }

        [Test]
        public void Sub_PassCase()
        {
            Assert.AreEqual(-1, calculator.Sub(1, 2));
        }

        [Test]
        public void Sub_FailCase()
        {
            Assert.AreEqual(1, calculator.Sub(1, 2));
        }

        [Test]
        public void Prod_PassCase()
        {
            Assert.AreEqual(2, calculator.Prod(1, 2));
        }

        [Test]
        public void Prod_FailCase()
        {
            Assert.AreEqual(3, calculator.Prod(1, 2));
        }

        [Test]
        public void Div_PassCase()
        {
            Assert.AreEqual(0, calculator.Div(1, 2));
        }

        [Test]
        public void Div_FailCase()
        {
            Assert.AreEqual(1, calculator.Div(1, 2));
        }
    }
}
