﻿using System;
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
            Assert.AreEqual(true, false);
        }
        [TestMethod]
        public void testCompetitor()
        {
            var competitor = new Competitor();
            competitor.newCompetitor();
            Assert.(1, true);

        }
        [TestMethod]
        public void testJumpType()
        {
            var jumpType = new JumpType();
            Assert.AreEqual(true, false);
        }

    }

}
