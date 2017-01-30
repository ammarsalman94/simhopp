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
            //competitor 1
            var competitor1 = new Competitor("Joel", 12, 1);

            string s1 = (competitor1.testCount().ToString());
            Console.WriteLine($"Test1: {s1}");


            //competitor 2
            var competitor2 = new Competitor("Frans", 20, 2);
            string s2 = (competitor2.testCount().ToString());
            Console.WriteLine($"Test2: {s2}");

            //competiror 3
            var competitor3 = new Competitor("Olle", 9, 3);
            string s3 = (competitor3.testCount().ToString());

            //competitor 4
            var competitor4 = new Competitor("anden", 99, 4);
            string s4 = (competitor4.testCount().ToString());

            //Try
            Assert.AreEqual(0, competitor1.testCount());
            Assert.AreEqual(0, competitor2.testCount());
            Assert.AreEqual(0, competitor3.testCount());
            Assert.AreEqual(0, competitor4.testCount());

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
