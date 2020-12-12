using NUnit.Framework;

namespace NUnitTestProject1
{
    public class Tests
    {
        [TestCaseSource(typeof(Information_to_check), "PlusCases")]
        public void TestPlus(double x, double y, double z)
        {
            double result = Calc.Plus(x, y);
            Assert.AreEqual(z, result);
        }
        [TestCaseSource(typeof(Information_to_check), "MinusCases")]
        public void TestMinus(double x, double y, double z)
        {
            double result = Calc.Minus(x, y);
            Assert.AreEqual(z, result);
        }
        [TestCaseSource(typeof(Information_to_check), "DivisionCases")]
        public void TestDivide(double x, double y, double z)
        {
            double result = Calc.Division(x, y);
            Assert.AreEqual(z, result);
        }

        [TestCaseSource(typeof(Information_to_check), "MultiplicationCases")]
        public void TestMultiplication(double x, double y, double z)
        {
            double result = Calc.Multiplication(x, y);
            Assert.AreEqual(z, result);
        }
    }
}