using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CurrencyCalculatorTDD.Tests
{
    [TestClass]
    public class FrancTest
    {
        [TestMethod]
        public void TestFrancMultiplication()
        {
            Franc five = new Franc(5);
            Assert.AreEqual(new Franc(10), five.Times(2));
            Assert.AreEqual(new Franc(15), five.Times(3));
        }

        [TestMethod]
        public void TestEquals()
        {
            Assert.IsTrue(new Franc(5).Equals(new Franc(5)));
            Assert.IsFalse(new Franc(5).Equals(new Franc(6)));
        }
    }
}
