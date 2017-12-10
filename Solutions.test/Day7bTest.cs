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
    public class Day7bTest
    {
        private string testInput = @"pbga (66)
xhth (57)
ebii (61)
havc (66)
ktlj (57)
fwft (72) -> ktlj, cntj, xhth
qoyq (66)
padx (45) -> pbga, havc, qoyq
tknk (41) -> ugml, padx, fwft
jptl (61)
ugml (68) -> gyxo, ebii, jptl
gyxo (61)
cntj (57)";
        //[TestMethod]
        //public void ShouldReturn60()
        //{
        //    var result = new Day7b(testInput).Solve();

        //    Assert.AreEqual(60, result);
        //}

        private string minimalInput = @"pbga (66)
xhth (57)
ebii (61)
havc (66)
ktlj (57)
fwft (76) -> ktlj, cntj, xhth
qoyq (66)
padx (49) -> pbga, havc, qoyq
tknk (41) -> ugml, padx, fwft
jptl (61)
ugml (60) -> gyxo, ebii, jptl
gyxo (61) -> foo
cntj (57)
foo (4)";

        [TestMethod]
        public void ShouldReturn57()
        {
            var result = new Day7b(minimalInput).Solve();

            Assert.AreEqual(57, result);
        }

        [TestMethod]
        public void SubmittedResultMonica()
        {
            var result = new Day7b(TestInputs.Day7bMonica).Solve();

            Assert.AreEqual(910, result);
        }


        [TestMethod]
        public void SubmittedResultRyan()
        {
            var result = new Day7b(TestInputs.Day7bRyan).Solve();

            Assert.AreEqual(1072, result);
        }
    }
}
