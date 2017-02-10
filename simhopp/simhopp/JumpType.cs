using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simhopp
{
    public class JumpType
    {
        public SortedDictionary<int, string> jumpStats = new SortedDictionary<int, string>(); // jumpstats[0] == (volt)
        public SortedDictionary<int, string> startPos = new SortedDictionary<int, string>(); // startPos[0] == (1, forward)
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

        public JumpType()
        {
            addStartPos();
            addjumpCombination();
            addqtyFlips();
            addqtyScrews();
            addjumpStats();
            addjumpHeight();
        }

        public string ShowContentsjumpStats()
        {
            var sb = new StringBuilder();
            foreach (KeyValuePair<int, string> item in jumpStats)
            {
                sb.Append(string.Format("key {0} is {1} \n", item.Key, item.Value));
            }
            return sb.ToString();
        }
        public SortedDictionary<int, string> addjumpStats() //Adding information about the jumpStyle to the dictionary
        {
            try
            {
                jumpStats.Add(1, "Rak");
                jumpStats.Add(2, "Pik");
                jumpStats.Add(3, "Gruppering");
                jumpStats.Add(4, "Valfri");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("An Element already exists with the same key");
            }
            return jumpStats;
        }

        public string ShowContentsStartPos() //printing elements in Class
        {
            var sb = new StringBuilder();
            foreach (KeyValuePair<int, string> item in startPos)
            {
                sb.Append(string.Format("key {0} is {1} \n", item.Key, item.Value));
            }
            return sb.ToString();
        }
        public SortedDictionary<int, string> addStartPos() // Adding information to the startPos Dictionary
        {

            startPos.Add(1, "Framåt");
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

            jumpCombination.Add(1, new List<string>() { "Flygande", "EjFlygande" });
            jumpCombination.Add(2, new List<string>() { "Flygande", "EjFlygande" });
            jumpCombination.Add(3, new List<string>() { "Flygande", "EjFlygande" });
            jumpCombination.Add(4, new List<string>() {"Flygande","EjFlygande"});
            jumpCombination.Add(5, new List<string>() {"Framåt","Bakåt","Isander/Mollbergare","Tyska"});
            jumpCombination.Add(6, new List<string>() {"Framåt","Bakåt","Mellanhopp"});
           
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
            qtyFlips.Add(1, 0);
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
            jumpHeight.Add(1, 1);
            jumpHeight.Add(2, 3);
            jumpHeight.Add(3, 5);
            jumpHeight.Add(4, 7.5);
            jumpHeight.Add(5, 10);


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
            qtyScrews.Add(5, new List<double>() { 0, 0.5, 1, 1.5, 2, 2.5, 3, 3.5, 4, 4.5, 5 });
            qtyScrews.Add(6, new List<double>() { 0, 0.5, 1, 1.5, 2, 2.5, 3, 3.5, 4, 4.5, 5 });
            return qtyScrews;
        }


        //public string createCompleteJump(int kID, int kID2, int kID3, int kID4, int kID5, double vScrews, string vJumpCombo,)
        public string createCompleteJump(int kID, int kID2, string vJumpCombo, int kID3, int kID4, double vScrews, int kID5, int kID6) //inmatning blir (2.5,"tyska",5........); 
        {
            var fail = "Invalid Selection of Jump!!!";
            var myKey = startPos[kID];
            var myKey2 = jumpCombination[kID2].FirstOrDefault(y => y == vJumpCombo);
            var myKey3 = qtyFlips[kID3];
            var myKey4 = qtyScrews[kID4].FirstOrDefault(y => y == vScrews);
            var myKey5 = jumpStats[kID5];
            var myKey6 = jumpHeight[kID6];

            switch (kID) // Constraints
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    myKey4 = 0;
                    if (kID2 == 5 || kID2 == 6)
                    {
                        return fail;
                    }
                    break;
                case 5:
                    if (kID2 != 5)
                    {
                        return fail;
                    }
                    break;
                case 6:
                    if (kID2 != 6)
                    {
                        return fail;
                    }
                    break;
            }
            var str = $"{myKey} {myKey2} {myKey3} {myKey4} {myKey5} {myKey6}";
            //Console.Write("StartPos: " + myKey + " jumpCombo: " + myKey2 + " Flips: " + myKey3 + " Screws: " + myKey4 + " jumpStats: " + myKey5 + " JumpHeight: " + myKey6);
            // Console.Write("\nCompleteJump:" + str);
            return str;
        }

        
        
        public string diveNumberTranslator(string divenumber)
        {
            string translatedDiveNumber = "";
            string Fail = "Error";
            int i = 0;
            switch (i)
            {
                case 0:
                    if (divenumber.Split(' ')[i] == "Framåt")
                        translatedDiveNumber += "1 ";
                    else if (divenumber.Split(' ')[i] == "Bakåt")
                        translatedDiveNumber += "1 ";
                    else if (divenumber.Split(' ')[i] == "Isander/Mollbergare")
                        translatedDiveNumber += "1 ";
                    else if (divenumber.Split(' ')[i] == "Tyska")
                        translatedDiveNumber += "1 ";
                    else
                        translatedDiveNumber += Fail;
                    i++;
                    break;
                case 1:
                    if (divenumber.Split(' ')[i] == "Framåt")
                        translatedDiveNumber += "1 ";
                    else if (divenumber.Split(' ')[i] == "Bakåt")
                        translatedDiveNumber += "1 ";
                    else if (divenumber.Split(' ')[i] == "Isander/Mollbergare")
                        translatedDiveNumber += "1 ";
                    else if (divenumber.Split(' ')[i] == "Tyska")
                        translatedDiveNumber += "1 ";
                    else
                        translatedDiveNumber += Fail;
                    i++;
                    break;

                case 2:
                    if (divenumber.Split(' ')[i] == "Framåt")
                        translatedDiveNumber += "1 ";
                    else if (divenumber.Split(' ')[i] == "Bakåt")
                        translatedDiveNumber += "1 ";
                    else if (divenumber.Split(' ')[i] == "Isander/Mollbergare")
                        translatedDiveNumber += "1 ";
                    else if (divenumber.Split(' ')[i] == "Tyska")
                        translatedDiveNumber += "1 ";
                    else
                        translatedDiveNumber += Fail;
                    i++;
                    break;

                case 3:
                    if (divenumber.Split(' ')[i] == "Framåt")
                        translatedDiveNumber += "1 ";
                    else if (divenumber.Split(' ')[i] == "Bakåt")
                        translatedDiveNumber += "1 ";
                    else if (divenumber.Split(' ')[i] == "Isander/Mollbergare")
                        translatedDiveNumber += "1 ";
                    else if (divenumber.Split(' ')[i] == "Tyska")
                        translatedDiveNumber += "1 ";
                    else
                        translatedDiveNumber += Fail;
                    i++;
                    break;

                case 4:
                    if (divenumber.Split(' ')[i] == "Framåt")
                        translatedDiveNumber += "1 ";
                    else if (divenumber.Split(' ')[i] == "Bakåt")
                        translatedDiveNumber += "1 ";
                    else if (divenumber.Split(' ')[i] == "Isander/Mollbergare")
                        translatedDiveNumber += "1 ";
                    else if (divenumber.Split(' ')[i] == "Tyska")
                        translatedDiveNumber += "1 ";
                    else
                        translatedDiveNumber += Fail;
                    i++;
                    break;

                case 5:
                    if (divenumber.Split(' ')[i] == "Framåt")
                        translatedDiveNumber += "1 ";
                    else if (divenumber.Split(' ')[i] == "Bakåt")
                        translatedDiveNumber += "1 ";
                    else if (divenumber.Split(' ')[i] == "Isander/Mollbergare")
                        translatedDiveNumber += "1 ";
                    else if (divenumber.Split(' ')[i] == "Tyska")
                        translatedDiveNumber += "1";
                    else
                        translatedDiveNumber += Fail;
                    break;
            }


            return translatedDiveNumber;
        }















































        public double getDifficulty(string diveNumber)
        {
            double fail = 0;
            double difficulty =0;
            //1(1-4)
            if (diveNumber.Split(' ')[0] == "Framåt" || diveNumber.Split(' ')[0] == "Bakåt" || diveNumber.Split(' ')[0] == "Isander/Mollbergare" || diveNumber.Split(' ')[0] == "Tyska")
            {
                //2(1-4)(Flygande,EjFlygande)
                if (diveNumber.Split(' ')[1] == "Flygande" || diveNumber.Split(' ')[1] == "EjFlygande")
                {
                    //3(1-11)(0-5)
                    if (diveNumber.Split(' ')[2] == "0" || diveNumber.Split(' ')[2] == "0,5" || diveNumber.Split(' ')[2] == "1" || diveNumber.Split(' ')[2] == "1,5" || diveNumber.Split(' ')[2] == "2" || diveNumber.Split(' ')[2] == "2,5" || diveNumber.Split(' ')[2] == "3" || diveNumber.Split(' ')[2] == "3,5" || diveNumber.Split(' ')[2] == "4" || diveNumber.Split(' ')[2] == "4,5" || diveNumber.Split(' ')[2] == "5")
                    {
                        //4(5-6)(0-5)
                        if (diveNumber.Split(' ')[3] == "0")
                        {
                            //4(1-4)
                            if (diveNumber.Split(' ')[4] == "Rak" || diveNumber.Split(' ')[4] == "Pik" || diveNumber.Split(' ')[4] == "Gruppering" || diveNumber.Split(' ')[4] == "Valfri")
                            {
                                //5(1-5)(1-10)
                                if (diveNumber.Split(' ')[5] == "1" || diveNumber.Split(' ')[5] == "3" || diveNumber.Split(' ')[5] == "5" || diveNumber.Split(' ')[5] == "7,5" || diveNumber.Split(' ')[5] == "10")
                                {
                                    return difficulty += 4;
                                }
                                else
                                    return fail;
                            }
                            else
                                return fail;
                        }
                        else return fail;
                    }
                    else
                        return fail;
                }
                else
                    return fail;
            }
            //1(5)
            else if (diveNumber.Split(' ')[0] == "Skruvhopp")
            {
                //2(5)(Framåt, Bakåt, Isander/Mollbergare, Tyska)
                if (diveNumber.Split(' ')[1] == "Framåt" || diveNumber.Split(' ')[1] == "Bakåt" || diveNumber.Split(' ')[1] == "Isander/Mollbergare" || diveNumber.Split(' ')[1] == "Tyska")
                {
                    //3(1-11)(0-5)
                    if (diveNumber.Split(' ')[2] == "0" || diveNumber.Split(' ')[2] == "0,5" || diveNumber.Split(' ')[2] == "1" || diveNumber.Split(' ')[2] == "1,5" || diveNumber.Split(' ')[2] == "2" || diveNumber.Split(' ')[2] == "2,5" || diveNumber.Split(' ')[2] == "3" || diveNumber.Split(' ')[2] == "3,5" || diveNumber.Split(' ')[2] == "4" || diveNumber.Split(' ')[2] == "4,5" || diveNumber.Split(' ')[2] == "5")
                    {
                        //4(5-6)(0-5)
                        if (diveNumber.Split(' ')[3] == "0" || diveNumber.Split(' ')[3] == "0,5" || diveNumber.Split(' ')[3] == "1" || diveNumber.Split(' ')[3] == "1,5" || diveNumber.Split(' ')[3] == "2" || diveNumber.Split(' ')[3] == "2,5" || diveNumber.Split(' ')[3] == "3" || diveNumber.Split(' ')[3] == "3,5" || diveNumber.Split(' ')[3] == "4" || diveNumber.Split(' ')[3] == "4,5" || diveNumber.Split(' ')[3] == "5")
                        {
                            //4(1-4)
                            if (diveNumber.Split(' ')[4] == "Rak" || diveNumber.Split(' ')[4] == "Pik" || diveNumber.Split(' ')[4] == "Gruppering" || diveNumber.Split(' ')[4] == "Valfri")
                            {
                                //5(1-5)(1-10)
                                if (diveNumber.Split(' ')[5] == "1" || diveNumber.Split(' ')[5] == "3" || diveNumber.Split(' ')[5] == "5" || diveNumber.Split(' ')[5] == "7,5" || diveNumber.Split(' ')[5] == "10")
                                {
                                    return difficulty = 7;
                                }
                                else
                                    return fail;
                            }
                            else
                                return fail;
                        }
                        else
                            return fail;
                    }
                    else
                        return fail;
                }
                else
                    return fail;
            }
            //1(6)
            else if (diveNumber.Split(' ')[0] == "Handstans")
            {
                //2(6)(Framåt, Bakåt, Mellanhopp)
                if (diveNumber.Split(' ')[1] == "Framåt" || diveNumber.Split(' ')[1] == "Bakåt" || diveNumber.Split(' ')[1] == "Mellanhopp")
                {
                    //3(1-11)(0-5)
                    if (diveNumber.Split(' ')[2] == "0" || diveNumber.Split(' ')[2] == "0,5" || diveNumber.Split(' ')[2] == "1" || diveNumber.Split(' ')[2] == "1,5" || diveNumber.Split(' ')[2] == "2" || diveNumber.Split(' ')[2] == "2,5" || diveNumber.Split(' ')[2] == "3" || diveNumber.Split(' ')[2] == "3,5" || diveNumber.Split(' ')[2] == "4" || diveNumber.Split(' ')[2] == "4,5" || diveNumber.Split(' ')[2] == "5")
                    {
                        //4(5-6)(0-5)
                        if (diveNumber.Split(' ')[3] == "0" || diveNumber.Split(' ')[3] == "0,5" || diveNumber.Split(' ')[3] == "1" || diveNumber.Split(' ')[3] == "1,5" || diveNumber.Split(' ')[3] == "2" || diveNumber.Split(' ')[3] == "2,5" || diveNumber.Split(' ')[3] == "3" || diveNumber.Split(' ')[3] == "3,5" || diveNumber.Split(' ')[3] == "4" || diveNumber.Split(' ')[3] == "4,5" || diveNumber.Split(' ')[3] == "5")
                        {
                            //4(1-4)
                            if (diveNumber.Split(' ')[4] == "Rak" || diveNumber.Split(' ')[4] == "Pik" || diveNumber.Split(' ')[4] == "Gruppering" || diveNumber.Split(' ')[4] == "Valfri")
                            {
                                //5(1-5)(1-10)
                                if (diveNumber.Split(' ')[5] == "1" || diveNumber.Split(' ')[5] == "3" || diveNumber.Split(' ')[5] == "5" || diveNumber.Split(' ')[5] == "7,5" || diveNumber.Split(' ')[5] == "10")
                                {
                                    return difficulty = 10;
                                }
                                else
                                    return fail;
                            }
                            else
                                return fail;
                        }
                        else
                            return fail;
                    }
                    else
                        return fail;
                }
                else
                    return fail;
            }
            else
                return fail;
            

        }




    }
}

