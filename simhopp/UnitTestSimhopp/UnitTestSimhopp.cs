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
            var game = new Competition("Wt-game", 1);

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

            Console.WriteLine("-----     StartPos[0]       -----");
            SortedDictionary<int, string> s = jumpType.addStartPos();
            Console.WriteLine(jumpType.ShowContentsStartPos());

            Console.WriteLine("-----     jumpCombo[1]       -----");
            SortedDictionary<int, List<string>> d = jumpType.addjumpCombination();
            Console.WriteLine(jumpType.ShowContentsjumpCombination());

            Console.WriteLine("-----     qtyFlips[2]       -----");
            SortedDictionary<int,double> e = jumpType.addqtyFlips();
            Console.WriteLine(jumpType.ShowContentsaddqtyFlips());

            Console.WriteLine("-----     qtyScrews[3]       -----");
            SortedDictionary<int, List<double>> h = jumpType.addqtyScrews();
            Console.WriteLine(jumpType.ShowContentsaddqtyScrews());

            Console.WriteLine("-----     jumpstats[4]       -----");
            SortedDictionary<string, List<double>> g = jumpType.addjumpStats();
            Console.WriteLine(jumpType.ShowContentsjumpStats());

        }

        [TestMethod]
        public void testPoints()
        {
            var points = new Points();

            Assert.AreEqual(180, points.pointResult(1.6, 2, 6, 10, 34));
            




        }

    }

}
