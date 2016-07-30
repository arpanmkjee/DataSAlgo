using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using W1A1;

namespace UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(6, Program.MaxPairwiseProduct(3, new long[] { 1, 2, 3 }));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(140, Program.MaxPairwiseProduct(10, new long[] { 7, 5, 14, 2, 8, 8, 10, 1, 2, 3 }));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(36, Program.MaxPairwiseProduct(5, new long[] { 4, 6, 2, 6, 1 }));
        }


        [TestMethod]
        public void TestMethod4()
        {
            //Just making sure solution runs under 1 sec
            Assert.IsTrue(Time(() => Program.MaxPairwiseProduct(200000, Enumerable.Repeat<long>(0, 200000).ToArray()))<=TimeSpan.FromSeconds(1));


            Assert.AreEqual(0, Program.MaxPairwiseProduct(200000, Enumerable.Repeat<long>(0, 200000).ToArray()));
        }

        private TimeSpan Time(Action toTime)
        {
            var timer = Stopwatch.StartNew();
            toTime();
            timer.Stop();
            return timer.Elapsed;
        }
    }
}
