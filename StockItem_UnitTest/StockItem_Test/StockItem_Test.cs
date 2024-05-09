using StockItem_UnitTest;

namespace StockItem_Test
{
    [TestClass]
    public class StockItem_Test
    {
        [TestMethod]
        public void SetStatusByStockAmountTestIfNumberIsZero()
        {
            StockItem stockItemObj = new StockItem(1, "Kilincs", "1", "Kilincs Gyarto Kft.", "EX-F100", 0, DateTime.Parse("2022-12-01"), true);
            stockItemObj.SetStatusByStockAmount();
            Assert.IsFalse(stockItemObj.Status);
        }

        [TestMethod]
        public void SetStatusByStockAmountTestIfNumberIsNegative()
        {
            StockItem stockItemObj = new StockItem(1, "Kilincs", "1", "Kilincs Gyarto Kft.", "EX-F100", -5, DateTime.Parse("2022-12-01"), true);
            Exception exception = Assert.ThrowsException<StockItemException>(() => stockItemObj.SetStatusByStockAmount());
            string actual = exception.Message;
            string expected = "A raktarkeszlet nem lehet negativ szam!";
            Assert.AreEqual(expected, actual);
        }

        //Az oszt�lyon bel�li r�gz�t�si id�(PublishDate) be�ll�t�s�ra k�sz�ts�nk
        //egys�gteszteket! Vizsg�ljuk meg, hogy milyen d�tumform�tum eset�ben t�rik el a
        //teszt! A konstruktorn�l �s a setter h�v�s�n�l is vizsg�ljuk a d�tumform�tumot!

        [TestMethod]
        public void TestPublishDateSetWithSetter()
        {
            StockItem stockItemObj = new StockItem(1, "Kilincs", "1", "Kilincs Gyarto Kft.", "EX-F100", 200, DateTime.Parse("2022-12-01"), true);
            stockItemObj.PublishDate = DateTime.Today;
            DateTime actual = stockItemObj.PublishDate;
            DateTime expected = DateTime.Today;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestPublishDateSetWithConstructor()
        {
            StockItem stockItemObj = new StockItem(1, "Kilincs", "1", "Kilincs Gyarto Kft.", "EX-F100", 200, DateTime.Parse("2022-12-01"), true);
        }
    }
}