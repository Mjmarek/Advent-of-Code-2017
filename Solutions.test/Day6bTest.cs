using Challenges;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.test
{
    [TestClass]
    public class Day6bTest
    {
        [TestMethod]
        public void ShouldReturn4()
        {
            var input = @"0 2 7 0";

            var result = new Day6b(input).Solve();

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void SubmittedResultMonica()
        {
            var input = @"0	5	10	0	11	14	13	4	11	8	8	7	1	4	12	11";

            var result = new Day6b(input).Solve();

            Assert.AreEqual(1695, result);
        }

        [TestMethod]
        public void SubmittedResultRyan()
        {
            var input = @"10	3	15	10	5	15	5	15	9	2	5	8	5	2	3	6";

            var result = new Day6b(input).Solve();

            Assert.AreEqual(2765, result);
        }
    }
}
