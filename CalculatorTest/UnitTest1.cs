using Calculator;

namespace CalculatorTest
{
    [TestClass]
    public class CalcTests
    {
        CalculatorClass calculatorObj = new CalculatorClass();
        [TestMethod]
        public void SumTest()
        {
            int a = 7;
            int b = 6;

            int result = calculatorObj.Sum(a, b);
            Assert.AreEqual(13, result);
        }

        [TestMethod]
        public void SubTest()
        {
            
            int a = 7;
            int b = 6;

            int result = calculatorObj.Substract(a, b);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void DivideTest()
        {
            
            int a = 7;
            int b = 6;

            double result = calculatorObj.Divide(a, b);
            Assert.AreEqual(1.16666666, result, 0.00001);
        }

        [TestMethod]
        public void MutliplyTest()
        {
            
            int a = 7;
            int b = 6;

            int result = calculatorObj.Multiply(a, b);
            Assert.AreEqual(42, result);
        }
    }
}