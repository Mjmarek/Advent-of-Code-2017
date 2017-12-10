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
    public class Day9Test
    {
        private string testInput = @"{{<!!>},{<!!>},{<!!>},{<!!>}}";
        private string testInput2 = @"{{<a!>},{<a!>},{<a!>},{<ab>}}";

        [TestMethod]
        public void ShouldReturn9()
        {
            var result = new Day9(testInput).Solve();

            Assert.AreEqual(9, result);
        }
        [TestMethod]
        public void ShouldReturn3()
        {
            var result = new Day9(testInput2).Solve();

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void ShouldReturn10Garbagecount()
        {
            var target = new Day9("<{o\"i!a,<{i<a>");
            target.Solve();

            Assert.AreEqual(10, target.GarbageCount);
        }

        [TestMethod]
        public void SubmittedResultMonicaPartB()
        {
            var target = new Day9(TestInputs.Day9Monica);
            target.Solve();

            Assert.AreEqual(7539, target.GarbageCount);
        }

        [TestMethod]
        public void SubmittedResultRyanPartB()
        {
            var target = new Day9(TestInputs.Day9Ryan);
            target.Solve();

            Assert.AreEqual(6285, target.GarbageCount);
        }

        [TestMethod]
        public void SubmittedResultMonica()
        {
            var result = new Day9(TestInputs.Day9Monica).Solve();

            Assert.AreEqual(17537, result);
        }



        [TestMethod]
        public void SubmittedResultRyan()
        {
            var result = new Day9(TestInputs.Day9Ryan).Solve();

            Assert.AreEqual(11846, result);
        }
    }
}
