using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenges;

namespace Solutions.test
{
    [TestClass]
    public class Day12bTest
    {
        [TestMethod]
        public void ShouldReturn2()
        {
            var input = @"0 <-> 2
1 <-> 1
2 <-> 0, 3, 4
3 <-> 2, 4
4 <-> 2, 3, 6
5 <-> 6
6 <-> 4, 5";

            var result = new Day12b(input).Solve();

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void SubmittedResultMonica()
        {
            var result = new Day12b(TestInputs.Day12Monica).Solve();

            Assert.AreEqual(193, result);
        }

        [TestMethod]
        public void SubmittedResultRyan()
        {
            var result = new Day12b(TestInputs.Day12Ryan).Solve();

            Assert.AreEqual(181, result);
        }
    }
}
