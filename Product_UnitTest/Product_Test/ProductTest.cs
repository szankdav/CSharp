using Product_UnitTest;

namespace Product_Test
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void GetGrossPriceTest1()
        {
            Product productObj = new Product(1, "Kacsa", 2500.00, 27.00, 10);
            double actual = productObj.GetGrossPrice();
            double expected = 3175;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetGrossPriceTest2()
        {
            Product productObj = new Product(1, "Liba", 1745.00, 20.00, 10);
            double actual = productObj.GetGrossPrice();
            double expected = 2094;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetGrossPriceTest3()
        {
            Product productObj = new Product(1, "Kakas", 3864.00, 18.00, 10);
            double actual = productObj.GetGrossPrice();
            double expected = 4559.52;
            Assert.AreEqual(expected, actual, 0.00001);
        }

        [TestMethod]
        public void DoAllocateProduct1()
        {
            Product productObj = new Product(1, "Kakas", 3864.00, 18.00, 15);
            productObj.DoAllocateProduct(5);
            int actual = productObj.StockAmount;
            int expected = 10;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DoAllocateProduct2()
        {
            Product productObj = new Product(1, "Kakas", 3864.00, 18.00, 15);
            Exception exception = Assert.ThrowsException<ProductException>(() => productObj.DoAllocateProduct(20));
            string actual = exception.Message;
            string expected = "Nincs elegendõ mennyiség raktáron!";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DoAllocateProduct3()
        {
            Product productObj = new Product(1, "Kakas", 3864.00, 18.00, 15);
            Exception exception = Assert.ThrowsException<ProductException>(() => productObj.DoAllocateProduct(-5));
            string actual = exception.Message;
            string expected = "A foglalni kívánt mennyiség nem lehet negatív!";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProductTypeTest()
        {
            Product productObj = new Product(1, "Kakas", 3864.00, 18.00, 15);
            Assert.AreEqual(productObj.GetType(), typeof(Product));
        }

        [TestMethod]
        public void DoAllocateProductParamaterIsNumberTest()
        {
            Product productObj = new Product(1, "Kakas", 3864.00, 18.00, 15);
            productObj.DoAllocateProduct(5);
            int actual = productObj.StockAmount;
            int expected = 10;
            Assert.AreEqual(expected, actual);
        }
    }
}