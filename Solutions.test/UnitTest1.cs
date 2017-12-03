using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solutions.test
{
    [TestClass]
    public class Day1aTest
    {
        [TestMethod]
        public void ShouldReturn3For1122()
        {
            string input = "1122";

            var target = new Day1a();
            var result = target.DigitCount(input);

            Assert.AreEqual(3, result, "First example input should result in 3.");
        }

        [TestMethod]
        public void ShouldReturn4For1111()
        {
            string input = "1111";

            var target = new Day1a();
            var result = target.DigitCount(input);

            Assert.AreEqual(4, result, "Second example input should result in 4.");
        }

        [TestMethod]
        public void ShouldReturn1For1()
        {
            string input = "1";

            var target = new Day1a();
            var result = target.DigitCount(input);

            Assert.AreEqual(1, result, "Test input should result in 1.");
        }
    }
}
