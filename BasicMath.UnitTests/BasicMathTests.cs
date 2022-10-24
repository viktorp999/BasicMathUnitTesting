using NUnit.Framework;

namespace BasicMath.UnitTests
{
    [TestFixture]
    public class BasicMathTests
    {
        private BasicMath _math;

        [SetUp]
        public void SetUp()
        {
            _math = new BasicMath();
        }

        [Test]
        public void Add_WhenCalled_AddParameters()
        {
            double result = _math.Add(1,1);

            Assert.AreEqual(result, 2);
        }

        [Test]
        public void Sub_WhenCalled_SubstractParameters()
        {
            double result = _math.Sub(2, 1);

            Assert.AreEqual(result, 1);
        }

        [Test]
        public void Mul_WhenCalled_MultiplyParameters()
        {
            double result = _math.Mul(3, 3);

            Assert.AreEqual(result, 9);
        }

        [Test]
        public void Div_WhenCalled_DivideParameters()
        {
            double result = _math.Div(9, 3);

            Assert.AreEqual(result, 3);
        }
    }
}
