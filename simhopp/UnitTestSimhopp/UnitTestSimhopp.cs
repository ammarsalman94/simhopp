﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using simhopp;

namespace UnitTestSimhopp
{
    [TestClass]
    public class UnitTestSimhopp
    {

    //    [TestMethod]

    //    public void testCompetition()
    //    {
    //        var game = new Competition("Wt-game");

    //        //Test list for competitor if empty or not
    //        var competitor1 = new Competitor("Joel", 12);
    //        var competitor2 = new Competitor("frans", 12);
    //        var competitor3 = new Competitor("anden", 12);
    //        var competitor4 = new Competitor("carl", 12);
    //        var competitor5 = new Competitor("bertil", 12);
    //        var competitor6 = new Competitor("kjell", 14);

    //        game.addCompetitorToList(competitor1);
    //        game.addCompetitorToList(competitor2);
    //        game.addCompetitorToList(competitor3);
    //        game.addCompetitorToList(competitor4);
    //        game.addCompetitorToList(competitor5);
    //        game.addCompetitorToList(competitor6);



    //        Assert.AreEqual(6, game.countJumps());


    //        //Test list for judges if empty or not
    //        var judge1 = new Judge("Joel", 12);
    //        var judge2 = new Judge("frans", 12);
    //        var judge3 = new Judge("anden", 12);
    //        var judge4 = new Judge("carl", 12);
    //        var judge5 = new Judge("bertil", 12);
    //        var judge6 = new Judge("kjell", 14);

    //        game.addJudgeToList(judge1);
    //        game.addJudgeToList(judge2);
    //        game.addJudgeToList(judge3);
    //        game.addJudgeToList(judge4);
    //        game.addJudgeToList(judge5);
    //        game.addJudgeToList(judge6);


    //        Assert.AreEqual(6, game.countJudges());
    //        game.printJudgeList();
    //    }

    //    [TestMethod]
    //    public void testJudge()
    //    {
    //        var Judge = new Judge();
    //        var judge1 = new Judge("Joel", 12);
    //        var judge2 = new Judge("frans", 12);
    //        var judge3 = new Judge("anden", 12);
    //        var judge4 = new Judge("carl", 12);
    //        var judge5 = new Judge("bertil", 12);
    //        var judge6 = new Judge("kjell", 14);



    //    }

    //    [TestMethod]
    //    public void testCompetitor()
    //    {
    //        //competitor 1
    //        var competitor = new Competitor("Joel", 12);
    //        string s1 = (competitor.testCount().ToString());
    //        Console.WriteLine($"Test1: {s1}");

    //        //Try
    //        Assert.AreEqual(0, competitor.testCount());
    //    }

    //    [TestMethod]
    //    public void testJumpType()
    //    {
    //        var jumpType = new JumpType();

    //        //Console.WriteLine("-----     StartPos[0]       -----");
    //        //SortedDictionary<int, string> s = jumpType.addStartPos();
    //        //Console.WriteLine(jumpType.ShowContentsStartPos());

    //        //Console.WriteLine("-----     jumpCombo[1]       -----");
    //        //SortedDictionary<int, List<string>> d = jumpType.addjumpCombination();
    //        //Console.WriteLine(jumpType.ShowContentsjumpCombination());

    //        //Console.WriteLine("-----     qtyFlips[2]       -----");
    //        //SortedDictionary<int, double> e = jumpType.addqtyFlips();
    //        //Console.WriteLine(jumpType.ShowContentsaddqtyFlips());

    //        //Console.WriteLine("-----     qtyScrews[3]       -----");
    //        //SortedDictionary<int, List<double>> h = jumpType.addqtyScrews();
    //        //Console.WriteLine(jumpType.ShowContentsaddqtyScrews());

    //        //Console.WriteLine("-----     jumpstats[4]       -----");
    //        //SortedDictionary<int, string> g = jumpType.addjumpStats();
    //        //Console.WriteLine(jumpType.ShowContentsjumpStats());

    //        //Console.WriteLine("-----     jumpHeight[5]       -----");
    //        //SortedDictionary<int, double> f = jumpType.addjumpHeight();
    //        //Console.WriteLine(jumpType.ShowContentsaddjumpHeight());

    //        Console.WriteLine("-----     Create Complete Jump       -----");

    //        var res = jumpType.createCompleteJump(5,5,"Tyska",3,5,3.5,1,4);
    //        Console.Write(res);
    //    }



    //    [TestMethod]
    //    public void testPoints()
    //    {
    //        var points = new Points();


    //        Assert.AreEqual(180, points.pointResult(1.6, 2, 6, 10, 3,4));


    //    }

    //    [TestMethod]

    //    public void testRemoveCompetitorFromList()
    //    {
    //        var game = new Competition("Wt-game");

    //        //Test list for competitor if empty or not
    //        var competitor1 = new Competitor("Joel", 12);
    //        var competitor2 = new Competitor("frans", 12);
    //        var competitor3 = new Competitor("anden", 12);
    //        var competitor4 = new Competitor("carl", 12);
    //        var competitor5 = new Competitor("bertil", 12);
    //        var competitor6 = new Competitor("kjell", 14);

    //        game.addCompetitorToList(competitor1);
    //        game.addCompetitorToList(competitor2);
    //        game.addCompetitorToList(competitor3);
    //        game.addCompetitorToList(competitor4);
    //        game.addCompetitorToList(competitor5);
    //        game.addCompetitorToList(competitor6);
    //        game.printCompetitorList();
    //        game.removeCompetitorFromList(8);
    //        game.printCompetitorList();
    //        Assert.AreEqual(5, game.countJumps());
    //    }

    //    [TestMethod]
    //    public void testSeveralCompetitions()
    //    {
    //        var game1 = new Competition("Wt-game");
    //        var game2 = new Competition("Wth-game");

    //        var competitor1 = new Competitor("Joel", 12);
    //        var competitor2 = new Competitor("frans", 12);
    //        var competitor3 = new Competitor("anden", 12);
    //        var competitor4 = new Competitor("carl", 12);
    //        var competitor5 = new Competitor("bertil", 12);
    //        var competitor6 = new Competitor("kjell", 14);

    //        var competitor7 = new Competitor("Joel", 12);
    //        var competitor8 = new Competitor("frans", 12);
    //        var competitor9 = new Competitor("anden", 12);
    //        var competitor10 = new Competitor("carl", 12);
    //        var competitor11 = new Competitor("bertil", 12);
    //        var competitor12 = new Competitor("kjell", 14);

    //        var judge1 = new Judge("Joel", 12);
    //        var judge2 = new Judge("frans", 12);
    //        var judge3 = new Judge("anden", 12);
    //        var judge4 = new Judge("carl", 12);
    //        var judge5 = new Judge("bertil", 12);
    //        var judge6 = new Judge("kjell", 14);

    //        var judge7 = new Judge("Joel", 12);
    //        var judge8 = new Judge("frans", 12);
    //        var judge9 = new Judge("anden", 12);
    //        var judge10 = new Judge("carl", 12);
    //        var judge11 = new Judge("bertil", 12);
    //        var judge12 = new Judge("kjell", 14);

    //        game1.addJudgeToList(judge1);
    //        game1.addJudgeToList(judge2);
    //        game1.addJudgeToList(judge3);
    //        game1.addJudgeToList(judge4);
    //        game1.addJudgeToList(judge5);
    //        game1.addJudgeToList(judge6);

    //        game2.addJudgeToList(judge7);
    //        game2.addJudgeToList(judge8);
    //        game2.addJudgeToList(judge9);
    //        game2.addJudgeToList(judge10);
    //        game2.addJudgeToList(judge11);
    //        game2.addJudgeToList(judge12);



    //        game1.addCompetitorToList(competitor1);
    //        game1.addCompetitorToList(competitor2);
    //        game1.addCompetitorToList(competitor3);
    //        game1.addCompetitorToList(competitor4);
    //        game1.addCompetitorToList(competitor5);
    //        game1.addCompetitorToList(competitor6);

    //        game2.addCompetitorToList(competitor7);
    //        game2.addCompetitorToList(competitor8);
    //        game2.addCompetitorToList(competitor9);
    //        game2.addCompetitorToList(competitor10);
    //        game2.addCompetitorToList(competitor11);
    //        game2.addCompetitorToList(competitor12);
    //        Console.WriteLine("Game 1:");
    //        game1.printCompetitorList();
    //        game1.printJudgeList();
    //        Console.WriteLine("Game 2:");
    //        game2.printJudgeList();
    //        game2.printCompetitorList();
    //        Assert.AreEqual(true, true);
    //    }




    //    [TestMethod]
    //    public void testOldCompetition()
    //    {

    //        var oldcompetition = new StoreCompetition();

    //        var game1 = new Competition("Wt-game1");
    //        var game2 = new Competition("Wt-game2");
    //        var game3 = new Competition("Wt-game3");
    //        var game4 = new Competition("Wt-game4");
    //        var game5 = new Competition("Wt-game5");
    //        var game6 = new Competition("Wt-game6");

    //        oldcompetition.addCompetition(game1);
    //        oldcompetition.addCompetition(game2);
    //        oldcompetition.addCompetition(game3);
    //        oldcompetition.addCompetition(game4);
    //        oldcompetition.addCompetition(game5);
    //        oldcompetition.addCompetition(game6);


    //        oldcompetition.removeCompetittionFromList(5);



    //        Assert.AreEqual(5, oldcompetition.countOldCompetitions());
    //    }

       

    //    [TestMethod]
    //    public void testGetDifficulty()
    //    {
    //        var jumpType = new JumpType();

    //        Console.WriteLine(jumpType.createCompleteJump(5, 5, "Tyska", 3, 5, 3.5, 1, 4).ToString());
    //        string jump = jumpType.createCompleteJump(5, 5, "Tyska", 3, 5, 3.5, 1, 4);
    //        Console.WriteLine("Difficulty for (Skruvhopp Tyska 1 2,5 Pik 3): ");
    //        Console.WriteLine(jumpType.getDifficulty(jump));
    //    }




    //    [TestMethod]
    //    public void testAddJumpToCompetitor213()
    //    {
    //        var obj = new Competitor("frans", 23);

    //        obj.addJumpTypeToCompetitor(1,5, 5, "Isander/Mollbergare", 3, 5, 3.5, 1, 5);

    //        obj.addJumpTypeToCompetitor(1,5, 5, "Bakåt", 3, 5, 3.5, 1, 3);

    //        obj.addJumpTypeToCompetitor(1,6, 6, "Framåt", 3, 5, 3.5, 1, 1);

    //        obj.addJumpTypeToCompetitor(2,5, 5, "Mellanhopp", 3, 5, 3.5, 1, 2);
    //        obj.addJumpTypeToCompetitor(3,1, 1, "Flygande", 3, 5, 3.5, 1, 4);
    //        obj.addJumpTypeToCompetitor(4, 2, 2, "EjFlygande", 3, 5, 3.5, 1, 4);


    //        Console.WriteLine("first print:");
    //        obj.printCompetitorJumps();

    //        Console.WriteLine("Search for id that exists:");
    //        obj.searchCompetitorjumps(2);
    //        Console.WriteLine("Search for id that does not exist:");
    //        obj.searchCompetitorjumps(200);

    //        obj.removeCompetitorjumps(1);
    //        Console.WriteLine("after removing print:");
    //        obj.printCompetitorJumps();

    //        Assert.AreEqual(5,obj.countCompetitorJumps());

    //    }

        [TestMethod]
        public void testFullCompetition()
        {


            //game 1------------------------------------------------------------------------------
            var competitionList = new StoreCompetition();

            var game = new Competition("Wt-game");
            competitionList.addCompetition(game);
            
            var Judge = new Judge();
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

            competitor1.addJumpTypeToCompetitor(1, 5, 5, "Isander/Mollbergare", 3, 5, 3.5, 1, 5);
            competitor1.addJumpTypeToCompetitor(1, 5, 5, "Bakåt", 3, 5, 3.5, 1, 3);
            competitor1.addJumpTypeToCompetitor(1, 6, 6, "Framåt", 3, 5, 3.5, 1, 1);
            competitor2.addJumpTypeToCompetitor(2, 5, 5, "Mellanhopp", 3, 5, 3.5, 1, 2);
            competitor2.addJumpTypeToCompetitor(3, 1, 1, "Flygande", 3, 5, 3.5, 1, 4);
            competitor2.addJumpTypeToCompetitor(4, 2, 2, "EjFlygande", 3, 5, 3.5, 1, 4);

            competitionList.printOldCompetitionList();
            game.printFullCompetition();

        
            Assert.AreEqual(1, competitionList.countOldCompetitions());

            //game 2------------------------------------------------------------------------------

            var game1 = new Competition("WHITE TRASH GAME");
            competitionList.addCompetition(game1);

            game1.addJudgeToList(judge1);
            game1.addJudgeToList(judge2);
            game1.addJudgeToList(judge3);
            game1.addJudgeToList(judge4);
            game1.addJudgeToList(judge5);
            game1.addJudgeToList(judge6);

            game1.addCompetitorToList(competitor1);
            game1.addCompetitorToList(competitor2);
            game1.addCompetitorToList(competitor3);
            game1.addCompetitorToList(competitor4);
            game1.addCompetitorToList(competitor5);
            game1.addCompetitorToList(competitor6);


            Console.WriteLine("GAME2---------------------------------------------------------------------");
            competitionList.printOldCompetitionList();
            game1.printFullCompetition();


           Assert.AreEqual(2, competitionList.countOldCompetitions());
           Assert.AreEqual(3, competitor1.countCompetitorJumps());
            Assert.AreEqual(6,game.countJudges());
            Assert.AreEqual(6, game.countCompetitorsInCompetition());
            


            Assert.AreEqual(2, competitionList.countOldCompetitions());
           Assert.AreEqual(2, competitionList.countOldCompetitions());
           Assert.AreEqual(2, competitionList.countOldCompetitions());
           Assert.AreEqual(2, competitionList.countOldCompetitions());












        }

    }
}

