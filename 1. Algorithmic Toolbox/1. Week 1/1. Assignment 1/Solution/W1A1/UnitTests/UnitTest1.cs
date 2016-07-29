using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using W1A1;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("5", AplusB.Add("3", "2"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("16", AplusB.Add("9", "7"));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual("0", AplusB.Add("9", "x"));
        }
    }
}
