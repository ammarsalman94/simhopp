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
        }

        [TestMethod]
        public void testJudge()
        {
            var judge = new Judge();
        }
        [TestMethod]
        public void testCompetitor()
        {
            var competitor = new Competitor();
        }
        [TestMethod]
        public void testJumpType()
        {
            var jumpType = new JumpType();
        }

    }

}
