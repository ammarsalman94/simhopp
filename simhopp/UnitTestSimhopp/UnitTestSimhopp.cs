using System;
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
            var competitor = new Competitor("Frans", 12, "0000");
            string s = (competitor.testCount().ToString());
            Console.WriteLine("Test: ");
            Assert.AreEqual(0, competitor.testCount());

        }
        [TestMethod]
        public void testJumpType()
        {
            var jumpType = new JumpType();
            Assert.AreEqual(true, false);
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
