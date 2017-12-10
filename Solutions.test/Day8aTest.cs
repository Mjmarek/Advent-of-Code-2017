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
    public class Day8aTest
    {
        private string testInput = @"b inc 5 if a > 1
a inc 1 if b < 5
c dec -10 if a >= 1
c inc -20 if c == 10";

        [TestMethod]
        public void ShouldReturn1()
        {
            var result = new Day8a(testInput).Solve();

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void SubmittedResultMonica()
        {
            var result = new Day8a(TestInputs.Day8aMonica).Solve();

            Assert.AreEqual(4902, result);
        }

        [TestMethod]
        public void SubmittedResultRyan()
        {
            var result = new Day8a(TestInputs.Day8aRyan).Solve();

            Assert.AreEqual(3089, result);
        }
    }
}
