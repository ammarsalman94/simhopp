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

            //Test list for competitor if empty or not
            var competitor1 = new Competitor("Joel", 12, 1);
            var competitor2 = new Competitor("frans", 12, 2);
            var competitor3 = new Competitor("anden", 12, 3);
            var competitor4 = new Competitor("carl", 12, 4);
            var competitor5 = new Competitor("bertil", 12, 5);
            var competitor6 = new Competitor("kjell", 14, 6);

            game.addCompetitorToList(competitor1);
            game.addCompetitorToList(competitor2);
            game.addCompetitorToList(competitor3);
            game.addCompetitorToList(competitor4);
            game.addCompetitorToList(competitor5);
            game.addCompetitorToList(competitor6);

            Assert.AreEqual(6, game.countJumps());

            //Test list for judges if empty or not
            var judge1 = new Judge("Joel", 12, 1);
            var judge2 = new Judge("frans", 12, 2);
            var judge3 = new Judge("anden", 12, 3);
            var judge4 = new Judge("carl", 12, 4);
            var judge5 = new Judge("bertil", 12, 5);
            var judge6 = new Judge("kjell", 14, 6);

            game.addJudgeToList(judge1);
            game.addJudgeToList(judge2);
            game.addJudgeToList(judge3);
            game.addJudgeToList(judge4);
            game.addJudgeToList(judge5);
            game.addJudgeToList(judge6);

            Assert.AreEqual(6, game.countJudges());

        }

        [TestMethod]
        public void testJudge() 
        {
            //competitor 1
            var judge = new Competitor("Joel", 12, 1);
            string s1 = (judge.testCount().ToString());

            Assert.AreEqual(true, false);
        }

        [TestMethod]
        public void testCompetitor()
        {
            //competitor 1
            var competitor = new Competitor("Joel", 12, 1);
            string s1 = (competitor.testCount().ToString());
            Console.WriteLine($"Test1: {s1}");


   

            //Try
            Assert.AreEqual(0, competitor.testCount());


        }

        [TestMethod]
        public void testJumpType()
        {
            var jumpType = new JumpType();
            SortedDictionary<string, List<int>> s = jumpType.addjumpStats();
            Console.WriteLine(jumpType.ShowContents());
           // Assert.AreEqual(10,jumpType.addJumpInfo().Values);
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
