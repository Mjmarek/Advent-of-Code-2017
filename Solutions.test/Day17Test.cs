using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenges;

namespace Solutions.test
{
    [TestClass]
    public class Day17Test
    {
        private int testInput = 3;

        [TestMethod]
        public void ShouldReturn638()
        {
            var result = new Day17a(testInput).Solve();

            Assert.AreEqual(638, result);
        }

        [TestMethod]
        public void SubmittedResultMonicaPartA()
        {
            var result = new Day17a(367).Solve();

            Assert.AreEqual(1487, result);
        }


        [TestMethod]
        public void SubmittedResultRyanPartA()
        {
            var result = new Day17a(355).Solve();

            Assert.AreEqual(1912, result);
        }

        [TestMethod]
        public void SubmittedResultMonicaPartB()
        {
            var result = new Day17b(367).Solve();

            Assert.AreEqual(25674054, result);
        }


        [TestMethod]
        public void SubmittedResultRyanPartB()
        {
            var result = new Day17b(355).Solve();

            Assert.AreEqual(21066990, result);
        }
    }
}
