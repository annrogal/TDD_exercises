using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CurrencyCalculatorTDD.Tests
{
    [TestClass]
    public class MoneyTest
    {
        [TestMethod]
        public void TestEquals()
        {
            Assert.IsTrue(Money.dollar(5).Equals(Money.dollar(5)));
            Assert.IsFalse(Money.dollar(5).Equals(Money.dollar(6)));
            Assert.IsTrue(Money.franc(5).Equals(Money.franc(5)));
        }

        public void TestDollarMultiplication()
        {
            Money five = Money.dollar(5);
            Assert.AreEqual(Money.dollar(10), five.Times(2));
            Assert.AreEqual(Money.dollar(15), five.Times(3));
        }

    }
}
