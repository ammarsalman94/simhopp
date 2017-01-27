using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using simhopp;

namespace UnitTestSimhopp
{
    [TestClass]
    public class UnitTestSimhopp
    {
        [TestMethod]
        public void testCompetition()
        {
            var game = new Competition();
            Assert.AreEqual(true, false);
        }
        [TestMethod]
        public void testJudge() 
        {
            var judge = new Judge();
            Assert.AreEqual(true, false);
        }
        [TestMethod]
        public void testCompetitor()
        {
            var competitor = new Competitor("Joel", 12, 1);
            string s = (competitor.testCount().ToString());
            Console.WriteLine($"Test: {s}");
            //alternatively
            Console.WriteLine("Test2: {0}",s);
            Assert.AreEqual(0, competitor.testCount());

        }
        [TestMethod]
        public void testJumpType()
        {
            var jumpType = new JumpType();
            SortedDictionary<string,Int32> s = jumpType.addJumpInfo();
            Console.WriteLine($"Test3: {s}");
        }
        [TestMethod]
        public void testPoints()
        {
            var points = new Points();
            Assert.AreEqual(true, false);
            points.getInfoJump();

        }
    }

}
