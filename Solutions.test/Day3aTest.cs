using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenges;

namespace Solutions.test
{
    [TestClass]
    public class Day3aTest
    {
        [TestMethod]
        public void ShouldReturn2ForSquare9()
        {
            var input = 9;
            var result = new Day3a(input).Solve();

            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void ShouldReturn2ForSquare23()
        {
            var input = 23;
            var result = new Day3a(input).Solve();

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void ShouldReturn31ForSquare1024()
        {
            var input = 1024;
            var result = new Day3a(input).Solve();

            Assert.AreEqual(31, result);
        }

        [TestMethod]
        public void SubmittedResultMonica()
        {
            var input = 289326;
            var result = new Day3a(input).Solve();

            Assert.AreEqual(419, result);
        }
        [TestMethod]
        public void SubmittedResultRyan()
        {
            var input = 277678;
            var result = new Day3a(input).Solve();

            Assert.AreEqual(475, result);
        }

    }
}
