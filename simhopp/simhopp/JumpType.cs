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
        SortedDictionary<string, List<int>> jumpStats = new SortedDictionary<string,List<int>>(); // jumpstats[0] == (volt, 10m)
        SortedDictionary<int,string> startPos; // startPos[0] == (1, forward)
        
        public int testCount()  // Counts how many objects a list has.
        {
            int c = 0;
            c = jumpStats.Count();
            return c;

        }

        public string ShowContents()
        {
            var sb = new StringBuilder();
            foreach (KeyValuePair<string, List<int>> item in jumpStats)
            {
                sb.Append(string.Format("{0}: has {1} entries with values {2}", item.Key, item.Value.Count(), string.Join(",", item.Value)));
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
        public SortedDictionary<string,List<int>> addjumpStats() //Adding information about the jump to the dictionary
        {
            try
            {
                jumpStats.Add("Volt", new List<int>());
                jumpStats["Volt"].Add(12);
                jumpStats["Volt"].Add(13);
                jumpStats["Volt"].Add(15);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("An Element already exists with the same key");
            }
            return jumpStats;
        }

        //alternatively:
        //private List<JumpType> jumpStats = new List<JumpType>(){get;set;};
        // private List<jumpType> startPos = new List<jumpStats>();
        // private List<jumpType> jumpHeight = new List<jumpStats>();
            //Add information to the list:
        //JumpStats.Add(new List<string> { "a", "b" });
            //Example of how to add these together at a later stage
        // jumpstart[0] && startPos[0] &&
    }
}

