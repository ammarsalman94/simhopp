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
            var competitor1 = new Competitor("Joel", 12);
            var competitor2 = new Competitor("frans", 12);
            var competitor3 = new Competitor("anden", 12);
            var competitor4 = new Competitor("carl", 12);
            var competitor5 = new Competitor("bertil", 12);
            var competitor6 = new Competitor("kjell", 14);

            game.addCompetitorToList(competitor1);
            game.addCompetitorToList(competitor2);
            game.addCompetitorToList(competitor3);
            game.addCompetitorToList(competitor4);
            game.addCompetitorToList(competitor5);
            game.addCompetitorToList(competitor6);



            Assert.AreEqual(6, game.countJumps());
            

            //Test list for judges if empty or not
            var judge1 = new Judge("Joel", 12);
            var judge2 = new Judge("frans", 12);
            var judge3 = new Judge("anden", 12);
            var judge4 = new Judge("carl", 12);
            var judge5 = new Judge("bertil", 12);
            var judge6 = new Judge("kjell", 14);

            game.addJudgeToList(judge1);
            game.addJudgeToList(judge2);
            game.addJudgeToList(judge3);
            game.addJudgeToList(judge4);
            game.addJudgeToList(judge5);
            game.addJudgeToList(judge6);


            Assert.AreEqual(6, game.countJudges());
            game.printJudgeList();
        }

        [TestMethod]
        public void testJudge()
        {
            var Judge = new Judge();
            var judge1 = new Judge("Joel", 12);
            var judge2 = new Judge("frans", 12);
            var judge3 = new Judge("anden", 12);
            var judge4 = new Judge("carl", 12);
            var judge5 = new Judge("bertil", 12);
            var judge6 = new Judge("kjell", 14);
            

      
        }

        [TestMethod]
        public void testCompetitor()
        {
            //competitor 1
            var competitor = new Competitor("Joel", 12);
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
            SortedDictionary<int, double> e = jumpType.addqtyFlips();
            Console.WriteLine(jumpType.ShowContentsaddqtyFlips());

            Console.WriteLine("-----     qtyScrews[3]       -----");
            SortedDictionary<int, List<double>> h = jumpType.addqtyScrews();
            Console.WriteLine(jumpType.ShowContentsaddqtyScrews());

            Console.WriteLine("-----     jumpstats[4]       -----");
            SortedDictionary<string, string> g = jumpType.addjumpStats();
            Console.WriteLine(jumpType.ShowContentsjumpStats());

            Console.WriteLine("-----     jumpHeight[5]       -----");
            SortedDictionary<int, double> f = jumpType.addjumpHeight();
            Console.WriteLine(jumpType.ShowContentsaddjumpHeight());

        }

        [TestMethod]
        public void testPoints()
        {
            var points = new Points();

            Assert.AreEqual(180, points.pointResult(1.6, 2, 6, 10, 34));


        }

        [TestMethod]

        public void testRemoveCompetitorFromList()
        {
            var game = new Competition("Wt-game", 1);

            //Test list for competitor if empty or not
            var competitor1 = new Competitor("Joel", 12);
            var competitor2 = new Competitor("frans", 12);
            var competitor3 = new Competitor("anden", 12);
            var competitor4 = new Competitor("carl", 12);
            var competitor5 = new Competitor("bertil", 12);
            var competitor6 = new Competitor("kjell", 14);

            game.addCompetitorToList(competitor1);
            game.addCompetitorToList(competitor2);
            game.addCompetitorToList(competitor3);
            game.addCompetitorToList(competitor4);
            game.addCompetitorToList(competitor5);
            game.addCompetitorToList(competitor6);
            game.printCompetitorList();
            game.removeCompetitorFromList(8);
            game.printCompetitorList();
            Assert.AreEqual(5, game.countJumps());
        }

        [TestMethod]
        public void testRemoveJudgeFromList()
        {
            var game = new Competition("Wt-game", 1);

            //Test list for competitor if empty or not
            var Judge1 = new Judge("Joel", 12);
            var Judge2 = new Judge("frans", 12);
            var Judge3 = new Judge("anden", 12);
            var Judge4 = new Judge("carl", 12);
            var Judge5 = new Judge("bertil", 12);
            var Judge6 = new Judge("kjell", 14);

            game.addJudgeToList(Judge1);
            game.addJudgeToList(Judge2);
            game.addJudgeToList(Judge3);
            game.addJudgeToList(Judge4);
            game.addJudgeToList(Judge5);
            game.addJudgeToList(Judge6);
            game.printJudgeList();
            game.removeJudgeFromList(13);
            game.printJudgeList();
            Assert.AreEqual(5, game.countJudges());
        }

    }
}
