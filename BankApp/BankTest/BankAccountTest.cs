using BankApp;

namespace BankTest
{
    [TestClass]
    public class BankAccountTest
    {
        [TestMethod]
        public void TestDebit()
        {
            BankAccount bankAccountObj = new BankAccount("Teszt Elek", 200.0);
            bankAccountObj.Debit(20.0);
            double actual = bankAccountObj.Balance;
            double expected = 180.0;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDebit2()
        {
            BankAccount bankAccountObj = new BankAccount("Teszt Elek", 200.0);
            bankAccountObj.Debit(110.0);
            double actual = bankAccountObj.Balance;
            double expected = 90.0;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCredit()
        {
            BankAccount bankAccountObj = new BankAccount("Teszt Elek", 200.0);
            bankAccountObj.Credit(20.0);
            double actual = bankAccountObj.Balance;
            double expected = 220.0;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCredit2()
        {
            BankAccount bankAccountObj = new BankAccount("Teszt Elek", 100.0);
            bankAccountObj.Credit(20.0);
            double actual = bankAccountObj.Balance;
            double expected = 120.0;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDebitWhenAmountOverBalanceCreateCustomException() 
        {
            BankAccount bankAccountObj = new BankAccount("Teszt Elek", 200.0);
            Assert.ThrowsException<BankAccountCustomException>(() => bankAccountObj.Debit(220.0));
        }

        [TestMethod]
        public void TestDebitWhenAmountOverBalanceGetBankAccountGetExceptionMessage()
        {
            BankAccount bankAccountObj = new BankAccount("Teszt Elek", 200.0);
            Exception exception = Assert.ThrowsException<BankAccountCustomException>(() => bankAccountObj.Debit(220.0));
            string actual = exception.Message;
            string expected = "Nincs eleg fedezet!";
            //Assert.AreEqual(expected, actual);
            Assert.IsTrue(actual.Contains(expected));
        }

        [TestMethod]
        public void TestDebitWhenAmountIsUnderZeroCreateCustomException()
        {
            BankAccount bankAccountObj = new BankAccount("Teszt Elek", 200.0);
            Assert.ThrowsException<BankAccountCustomException>(() => bankAccountObj.Debit(-10.0));
        }

        [TestMethod]
        public void TestDebitWhenAmountIsUnderZeroGetBankAccountGetExceptionMessage()
        {
            BankAccount bankAccountObj = new BankAccount("Teszt Elek", 200.0);
            Exception exception = Assert.ThrowsException<BankAccountCustomException>(() => bankAccountObj.Debit(-10.0));
            string actual = exception.Message;
            string expected = "Az osszeg nem lehet negativ!";
            //Assert.AreEqual(expected, actual);
            Assert.IsTrue(actual.Contains(expected));
        }

        [TestMethod]
        public void TestDebitWhenAmountOverDoubleMaxValueZeroCreateCustomException()
        {
            BankAccount bankAccountObj = new BankAccount("Teszt Elek", 200.0);
            Assert.ThrowsException<BankAccountCustomException>(() => bankAccountObj.Debit(double.MaxValue + 1));
        }

        [TestMethod]
        public void TestDebitWhenAmountOverDoubleMaxValueGetBankAccountGetExceptionMessage()
        {
            BankAccount bankAccountObj = new BankAccount("Teszt Elek", 200.0);
            Exception exception = Assert.ThrowsException<BankAccountCustomException>(() => bankAccountObj.Debit(double.MaxValue * 110));
            string actual = exception.Message;
            string expected = "Tul nagy osszeget adott meg!";
            //Assert.AreEqual(expected, actual);
            Assert.IsTrue(actual.Contains(expected));
        }

        [TestMethod]
        public void TestCreditWhenAmountOverDoubleMaxValueZeroCreateCustomException()
        {
            BankAccount bankAccountObj = new BankAccount("Teszt Elek", 200.0);
            Assert.ThrowsException<BankAccountCustomException>(() => bankAccountObj.Credit(double.MaxValue * 110));
        }

        [TestMethod]
        public void TestCreditWhenAmountOverDoubleMaxValueGetBankAccountGetExceptionMessage()
        {
            BankAccount bankAccountObj = new BankAccount("Teszt Elek", 200.0);
            Exception exception = Assert.ThrowsException<BankAccountCustomException>(() => bankAccountObj.Credit(double.MaxValue * 110));
            string actual = exception.Message;
            string expected = "Tul nagy osszeget adott meg!";
            //Assert.AreEqual(expected, actual);
            Assert.IsTrue(actual.Contains(expected));
        }

        [TestMethod]
        public void TestCreditWhenAmountIsUnderZeroCreateCustomException()
        {
            BankAccount bankAccountObj = new BankAccount("Teszt Elek", 200.0);
            Assert.ThrowsException<BankAccountCustomException>(() => bankAccountObj.Credit(-10.0));
        }

        [TestMethod]
        public void TestCreditWhenAmountIsUnderZeroGetBankAccountGetExceptionMessage()
        {
            BankAccount bankAccountObj = new BankAccount("Teszt Elek", 200.0);
            Exception exception = Assert.ThrowsException<BankAccountCustomException>(() => bankAccountObj.Credit(-10.0));
            string actual = exception.Message;
            string expected = "Az osszeg nem lehet negativ!";
            //Assert.AreEqual(expected, actual);
            Assert.IsTrue(actual.Contains(expected));
        }
    }
}