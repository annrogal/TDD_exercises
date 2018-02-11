using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CurrencyCalculatorTDD.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Dollar five = new Dollar(5);
            five.Times(2);
            Assert.AreEqual(10, five.amount);
        }
    }
}
