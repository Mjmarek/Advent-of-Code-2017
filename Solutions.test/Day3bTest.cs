using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenges;

namespace Solutions.test
{
    [TestClass]
    public class Day3bTest
    {
        [TestMethod]
        public void ShouldReturn2For1()
        {
            var input = 1;
            var result = new Day3b(input).Solve();

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void ShouldReturn23For11()
        {
            var input = 11;
            var result = new Day3b(input).Solve();

            Assert.AreEqual(23, result);
        }

        [TestMethod]
        public void SubmittedResult()
        {
            var input = 289326;
            var result = new Day3b(input).Solve();

            Assert.AreEqual(295229, result);
        }
    }
}
