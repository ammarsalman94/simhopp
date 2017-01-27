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
        private SortedDictionary<string, int> jumpStats; // jumpstats[0] == (volt, 10m)
        private SortedDictionary<int,string> startPos; // startPos[0] == (1, forward)
                                                       // jumpstart[0] && startPos[0] &&


        List<List<string>> myList = new List<List<string>>();
        IList.Add(new List<string> { "a", "b" });
        myList.Add(new List<string> { "c", "d", "e" });
        myList.Add(new List<string> { "qwerty", "asdf", "zxcv" });
        myList.Add(new List<string> { "a", "b" });

        // To iterate through it.
        foreach(List<string> subList in myList)
        {
            foreach (string item in subList)
            {
                Console.WriteLine(item);
            }
        }
    }
}

