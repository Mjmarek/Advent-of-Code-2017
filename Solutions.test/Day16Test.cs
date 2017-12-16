using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenges;

namespace Solutions.test
{
    [TestClass]
    public class Day16Test
    {
        [TestMethod]
        public void ExampleShouldReturnBaedc()
        {
            var programs = @"abcde";
            var danceMovesInput = @"s1,x3/4,pe/b";

            var result = new Day16(programs, danceMovesInput).Solve();

            Assert.AreEqual("baedc", result);
        }

        [TestMethod]
        public void SubmittedResultMonica()
        {
            var programs = @"abcdefghijklmnop";
            var danceMovesInput = TestInputs.Day16Monica;
            var result = new Day16(programs, TestInputs.Day16Monica).Solve();

            Assert.AreEqual("ociedpjbmfnkhlga", result);
        }

        [TestMethod]
        public void SubmittedResultMonicaPartB()
        {
            var programs = @"abcdefghijklmnop";
            var danceMovesInput = TestInputs.Day16Monica;
            var result = new Day16(programs, TestInputs.Day16Monica, 100000000).Solve();

            Assert.AreEqual("gnflbkojhicpmead", result);
        }

        [TestMethod]
        public void SubmittedResultRyanPartB()
        {
            var programs = @"abcdefghijklmnop";
            var danceMovesInput = TestInputs.Day16Monica;
            var result = new Day16(programs, TestInputs.Day16Ryan, 1000000000).Solve();

            Assert.AreEqual("ifocbejpdnklamhg", result);
        }

        [TestMethod]
        public void SubmittedResultRyan()
        {
            var programs = @"abcdefghijklmnop";
            var danceMovesInput = TestInputs.Day16Ryan;
            var result = new Day16(programs, TestInputs.Day16Ryan).Solve();

            Assert.AreEqual("dcmlhejnifpokgba", result);
        }
    }
}
