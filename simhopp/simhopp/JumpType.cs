﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simhopp
{
    public class JumpType
    {
        public SortedDictionary<string, string> jumpStats = new SortedDictionary<string, string>(); // jumpstats[0] == (volt)
        public SortedDictionary<int,string> startPos = new SortedDictionary<int, string>(); // startPos[0] == (1, forward)
        public SortedDictionary<int, List<string>> jumpCombination = new SortedDictionary<int, List<string>>(); // jumpCombination[0] == (1, flygande)
        public SortedDictionary<int, double> qtyFlips = new SortedDictionary<int, double>();
        public SortedDictionary<int, double> jumpHeight = new SortedDictionary<int, double>();
        public SortedDictionary<int, List<double>> qtyScrews = new SortedDictionary<int, List<double>>(); // qtyScrews[5/6] == (4/5, 0.5 increments)
        public int testCount()  // Counts how many objects a list has.
        {
            int c = 0;
            c = jumpStats.Count();
            return c;

        }
        //jumpStats
        public string ShowContentsjumpStats()
        {
            var sb = new StringBuilder();
            foreach (KeyValuePair<string, string> item in jumpStats)
            {
                sb.Append(string.Format("key {0} is {1} \n", item.Key, item.Value));
            }
            return sb.ToString();
            //    var str1 = "";
            //    var str2 = "";
            //    foreach (KeyValuePair<string, List<int>> item in jumpStats)
            //    {
            //        str1 = $"{item.Key} , has {item.Value.Count()} entries with the values: ";
            //        foreach (var item2 in item.Value)
            //        {
            //            str2 += $"{item2} ";
            //        }

            //    }
            //    return  "" + str1 + str2;
        }
        public SortedDictionary<string,string> addjumpStats() //Adding information about the jumpStyle to the dictionary
        {
            try
            {
                //jumpStats.Add("Rak", new List<double>()); // A
                //jumpStats["Rak"].Add(1);
                //jumpStats["Rak"].Add(3);
                //jumpStats["Rak"].Add(5);
                //jumpStats["Rak"].Add(7.5);
                //jumpStats["Rak"].Add(10);

                //jumpStats.Add("Pik", new List<double>()); // B
                //jumpStats["Pik"].Add(1);
                //jumpStats["Pik"].Add(3);
                //jumpStats["Pik"].Add(5);
                //jumpStats["Pik"].Add(7.5);
                //jumpStats["Pik"].Add(10);

                //jumpStats.Add("Gruppering", new List<double>()); // C
                //jumpStats["Gruppering"].Add(1);
                //jumpStats["Gruppering"].Add(3);
                //jumpStats["Gruppering"].Add(5);
                //jumpStats["Gruppering"].Add(7.5);
                //jumpStats["Gruppering"].Add(10);

                //jumpStats.Add("Valfri", new List<double>()); // D
                //jumpStats["Valfri"].Add(1);
                //jumpStats["Valfri"].Add(3);
                //jumpStats["Valfri"].Add(5);
                //jumpStats["Valfri"].Add(7.5);
                //jumpStats["Valfri"].Add(10);

                jumpStats.Add("A", "Rak");
                jumpStats.Add("B", "Pik");
                jumpStats.Add("C", "Gruppering");
                jumpStats.Add("D", "Valfri");

                //END OF JumpStats

            }
            catch (ArgumentException)
            {
                Console.WriteLine("An Element already exists with the same key");
            }
            return jumpStats;
        }
        //startPos
        public string ShowContentsStartPos() //printing elements in Class
        {
            var sb = new StringBuilder();
            foreach (KeyValuePair<int,string> item in startPos)
            {
                sb.Append(string.Format("key {0} is {1} \n", item.Key, item.Value));
            }
            return sb.ToString();
        }
        public SortedDictionary<int, string> addStartPos() // Adding information to the startPos Dictionary
        {
           
                startPos.Add(1,"Framåt");
                startPos.Add(2, "Bakåt");
                startPos.Add(3, "Isander/Mollbergare");
                startPos.Add(4, "Tyska");
                startPos.Add(5, "Skruvhopp");
                startPos.Add(6, "Handstans");
                
            return startPos;
        }
        //jumpCombination
        public string ShowContentsjumpCombination() // Printing elements in jumpCombination
        {
         
            var sb = new StringBuilder();
            foreach (KeyValuePair<int, List<string>> item in jumpCombination)
            {
                sb.Append(string.Format("{0}: has {1} entries with values {2} \n", item.Key, item.Value.Count(), string.Join(",", item.Value)));
            }
            return sb.ToString();

        }
        public SortedDictionary<int, List<string>> addjumpCombination() // Adding information to the jumpCombination dictionary
        {
            jumpCombination.Add(1, new List<string>());
                jumpCombination[1].Add("Flygande");
                jumpCombination[1].Add("Ej Flygande");
            jumpCombination.Add(2, new List<string>());
                jumpCombination[2].Add("Flygande");
                jumpCombination[2].Add("Ej Flygande");
            jumpCombination.Add(3, new List<string>());
                jumpCombination[3].Add("Flygande");
                jumpCombination[3].Add("Ej Flygande");
            jumpCombination.Add(4, new List<string>());
                jumpCombination[4].Add("Flygande");
                jumpCombination[4].Add("Ej Flygande");
            jumpCombination.Add(5, new List<string>());
                jumpCombination[5].Add("Framåt");
                jumpCombination[5].Add("Bakåt");
                jumpCombination[5].Add("Isander/Mollbergare");
                jumpCombination[5].Add("Tyska");
            jumpCombination.Add(6, new List<string>());
                jumpCombination[6].Add("Framåt");
                jumpCombination[6].Add("Bakåt");
                jumpCombination[6].Add("Mellanhopp");

            
            return jumpCombination;
        }
        //qtyFlipps
        public string ShowContentsaddqtyFlips() // Printing the information in qtyFlips
        {

            var sb = new StringBuilder();
            foreach (KeyValuePair<int, double> item in qtyFlips)
            {
                sb.Append(string.Format("id {0} are {1} flips \n", item.Key, item.Value));
            }
            return sb.ToString();

        }
        public SortedDictionary<int, double> addqtyFlips() // Adding information to the qtyFlips dictionary
        {
            qtyFlips.Add(1,0);
            qtyFlips.Add(2, 0.5);
            qtyFlips.Add(3, 1);
            qtyFlips.Add(4, 1.5);
            qtyFlips.Add(5, 2);
            qtyFlips.Add(6, 2.5);
            qtyFlips.Add(7, 3);
            qtyFlips.Add(8, 3.5);
            qtyFlips.Add(9, 4);
            qtyFlips.Add(10, 4.5);
            qtyFlips.Add(11, 5);

            return qtyFlips;
        }
        //jumpHeight
        public string ShowContentsaddjumpHeight() // Printing the information in jumpHeight
        {

            var sb = new StringBuilder();
            foreach (KeyValuePair<int, double> item in jumpHeight)
            {
                sb.Append(string.Format("id {0} are {1} height \n", item.Key, item.Value));
            }
            return sb.ToString();

        }
        public SortedDictionary<int, double> addjumpHeight() // Adding information to the qtyFlips dictionary
        {
            jumpHeight.Add(1, 0);
            jumpHeight.Add(2, 0.5);
            jumpHeight.Add(3, 1);
            jumpHeight.Add(4, 1.5);
            jumpHeight.Add(5, 2);
            jumpHeight.Add(6, 2.5);
            jumpHeight.Add(7, 3);
            jumpHeight.Add(8, 3.5);
            jumpHeight.Add(9, 4);
            jumpHeight.Add(10, 4.5);
            jumpHeight.Add(11, 5);

            return jumpHeight;
        }
        //qtyScrews
        public string ShowContentsaddqtyScrews() // Printing the information in qtyScrews, exclusively to id's 5 & 6
        {

            var sb = new StringBuilder();
            foreach (KeyValuePair<int, List<double>> item in qtyScrews)
            {
                sb.Append(string.Format("{0}: has {1} entries with values {2} \n", item.Key, item.Value.Count(),
                    string.Join(",", item.Value)));
            }
            return sb.ToString();

        }
        public SortedDictionary<int, List<double>> addqtyScrews() // adding information to the qtyScrews dictionary
        {
            qtyScrews.Add(5, new List<double>());
            qtyScrews[5].Add(0);
            qtyScrews[5].Add(0.5);
            qtyScrews[5].Add(1);
            qtyScrews[5].Add(1.5);
            qtyScrews[5].Add(2);
            qtyScrews[5].Add(2.5);
            qtyScrews[5].Add(3);
            qtyScrews[5].Add(3.5);
            qtyScrews[5].Add(4);
            qtyScrews[5].Add(4.5);
            qtyScrews[5].Add(5);
            qtyScrews.Add(6, new List<double>());
            qtyScrews[6].Add(0);
            qtyScrews[6].Add(0.5);
            qtyScrews[6].Add(1);
            qtyScrews[6].Add(1.5);
            qtyScrews[6].Add(2);
            qtyScrews[6].Add(2.5);
            qtyScrews[6].Add(3);
            qtyScrews[6].Add(3.5);
            qtyScrews[6].Add(4);
            qtyScrews[6].Add(4.5);
            qtyScrews[6].Add(5);

            return qtyScrews;
        }


        public void createCompleteJump()
        {
            int kID = 5; // Key ID
            double vID = 3; // Value ID
            string v2ID = "Framåt";
            var myKey = qtyScrews[kID].FirstOrDefault(y => y == vID);
            var myKey2 = qtyFlips[kID];
            var myKey3 = jumpCombination[kID].FirstOrDefault(y => y == v2ID);
            var myKey4 =jumpHeight[kID];
            var myKey5 = startPos[kID];

            //var myKey = addqtyScrews().FirstOrDefault(x => x.Key == kID && x.Value.Contains(vID)).Value;
 
            var str = $"{myKey}{myKey2}{myKey3}{myKey4}{myKey5}";
            Console.Write("Screws: " +myKey + " Flips: " + myKey2+ " jumpCombo: " + myKey3 + " JumpHeight: " + myKey4 + " startPos: " + myKey5);
           // var points = myKey + myKey2 + myKey3 + myKey4 + myKey5;
            Console.Write("\nCompleteJump:" + str);
        }

    }


       

}

