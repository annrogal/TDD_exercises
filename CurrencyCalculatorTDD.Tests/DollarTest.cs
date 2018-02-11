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
            Dollar five = new Dollar(5);
            Assert.AreEqual(new Dollar(10), five.Times(2));
            Assert.AreEqual(new Dollar(15), five.Times(3));
        }

        [TestMethod]
        public void TestEquals()
        {
            Assert.IsTrue(new Dollar(5).Equals(new Dollar(5)));
            Assert.IsFalse(new Dollar(5).Equals(new Dollar(6)));
        }
    }
}
