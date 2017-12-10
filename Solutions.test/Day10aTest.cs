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
    public class Day10aTest
    {
        [TestMethod]
        public void ShouldReturn12()
        {
            var inputElementCount = 5;
            var inputLengths = "3,4,1,5";

            var result = new Day10a(inputElementCount, inputLengths).Solve();

            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void SubmittedResultMonica()
        {
            var inputElementCount = 256;
            var inputLengths = "212,254,178,237,2,0,1,54,167,92,117,125,255,61,159,164";

            var result = new Day10a(inputElementCount, inputLengths).Solve();

            Assert.AreEqual(212, result);
        }

        [TestMethod]
        public void SubmittedResultRyan()
        {
            var inputElementCount = 256;
            var inputLengths = "63,144,180,149,1,255,167,84,125,65,188,0,2,254,229,24";

            var result = new Day10a(inputElementCount, inputLengths).Solve();

            Assert.AreEqual(4480, result);
        }
    }
}
