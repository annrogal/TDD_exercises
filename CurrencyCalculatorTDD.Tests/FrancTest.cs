﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CurrencyCalculatorTDD.Tests
{
    [TestClass]
    public class FrancTest
    {
        [TestMethod]
        public void TestFrancMultiplication()
        {
            Money five = Money.franc(5);
            Assert.AreEqual(Money.franc(10), five.Times(2));
            Assert.AreEqual(Money.franc(15), five.Times(3));
        }
    }
}
