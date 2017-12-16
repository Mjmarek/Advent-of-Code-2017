using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenges;

namespace Solutions.test
{
    [TestClass]
    public class Day16aTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var programs = @"abcde";
            var danceMovesInput = @"s1,x3/4,pe/b";

            var result = new Day16a(programs, danceMovesInput).Solve();

            Assert.AreEqual("baedc", result);
        }

        [TestMethod]
        public void SubmittedResultMonica()
        {
            var programs = @"abcdefghijklmnop";
            var danceMovesInput = TestInputs.Day16Monica;
            var result = new Day16a(programs, TestInputs.Day16Monica).Solve();

            Assert.AreEqual("ociedpjbmfnkhlga", result);
        }

        [TestMethod]
        public void SubmittedResultRyan()
        {
            var programs = @"abcdefghijklmnop";
            var danceMovesInput = TestInputs.Day16Ryan;
            var result = new Day16a(programs, TestInputs.Day16Ryan).Solve();

            Assert.AreEqual("dcmlhejnifpokgba", result);
        }
    }
}
