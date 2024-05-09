using DivideApp;
using System.Transactions;

namespace DivideTest
{
    [TestClass]
    public class DivideCalculateTest
    {
        [TestMethod]
        public void TestDivideCalculateWithIntParameter()
        {
            DivideCalculate divideCalculateObj = new DivideCalculate();
            double actual = divideCalculateObj.Divide(8, 4);
            double expected = 2;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDivideCalculateWithEndlessDoubleParameter()
        {
            DivideCalculate divideCalculateObj = new DivideCalculate();
            double actual = divideCalculateObj.Divide(10, 3);
            double expected = 3.333333333;
            Assert.AreEqual(expected, actual, 0.00001); // Delta: Mennyi elteres elfogadott. Hibatures.
        }

        [TestMethod]
        public void DivideCalculateWhenDividerIsZero()
        {
            DivideCalculate divideCalculateObj = new DivideCalculate();
            // Itt az az elvart viselkedes, hogy hibat dobjon!
            Assert.ThrowsException<DivideByZeroException>(() => divideCalculateObj.Divide(10, 0));
        }
    }
}