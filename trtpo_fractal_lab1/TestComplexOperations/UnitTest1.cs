using NUnit.Framework;

namespace TestComplexOperations
{
    [TestFixture]
    public class ComplexTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSubtraction()
        {
            var ob1 = new trtpo_fractal_lab1.Complex(5.0, 10.0);
            var ob2 = new trtpo_fractal_lab1.Complex(8.0, 4.0);
            double expected_re = -3, expected_im = 6;
            var ob_rezult = ob1 - ob2;
            Assert.AreEqual(expected_re, ob_rezult.Re);
            Assert.AreEqual(expected_im, ob_rezult.Im);
            Assert.Pass();
        }
        [Test]
        public void TestSquaring()
        {
            var ob = new trtpo_fractal_lab1.Complex(7.0, 9.0);
            double expected_re = -32, expected_im = 126;
            var ob_rezult = ob.sqr();
            Assert.AreEqual(expected_re, ob_rezult.Re);
            Assert.AreEqual(expected_im, ob_rezult.Im);
            Assert.Pass();
        }
    }
}