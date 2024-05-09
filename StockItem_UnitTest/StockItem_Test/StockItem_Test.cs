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

        //Az osztályon belüli rögzítési idõ(PublishDate) beállítására készítsünk
        //egységteszteket! Vizsgáljuk meg, hogy milyen dátumformátum esetében törik el a
        //teszt! A konstruktornál és a setter hívásánál is vizsgáljuk a dátumformátumot!

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