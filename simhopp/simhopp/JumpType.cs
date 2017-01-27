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
        SortedDictionary<string, Int32> jumpStats = new SortedDictionary<string,Int32>(); // jumpstats[0] == (volt, 10m)
        SortedDictionary<int,string> startPos; // startPos[0] == (1, forward)



        public SortedDictionary<string,Int32> addJumpInfo() //Adding information about the jump to the dictionary
        {
            try
            {
                jumpStats.Add("Volt", 10);
                jumpStats.Add("Volt",15);
                jumpStats.Add("Volt", 17);
                jumpStats.Add("Volt", 20);
            }
            catch(ArgumentException)
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

