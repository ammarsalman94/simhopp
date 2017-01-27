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
        public void test()
        {
            var competitor = new Competitor();
            Assert.AreEqual(true, false);
        }
        [TestMethod]
        public void testJumpType()
        {
            var jumpType = new JumpType();
            Assert.AreEqual(true, false);
        }
    }

}
