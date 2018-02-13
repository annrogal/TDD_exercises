using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CurrencyCalculatorTDD.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDollarMultiplication()
        {
            Money five = Money.dollar(5);
            Assert.AreEqual(Money.dollar(10), five.Times(2));
            Assert.AreEqual(Money.dollar(15), five.Times(3));
        }
    }
}
