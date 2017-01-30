using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;



namespace simhopp
{
  
    public class Competition
    {
        //Declaring variables
        private int id;
        private string name;
        private List<Competitor> competitorList = new List<Competitor>();
        private List<Judge> judgeList = new List<Judge>();
       




        //Functions

        public Competition(string name, int id) //Creating competition
        {
            this.id = id;
            this.name = name;

        }

        public void addCompetitorToList(Competitor obj)// add a comptetitor to a list of competitor
        {
            competitorList.Add(obj);
        }

        public void addJudgeToList(Judge obj)// adds a judge to a list o judges
        {
            judgeList.Add(obj);
        }

        public int countJumps()//counts amount of jumps
        {
            int count = 0;

            count = competitorList.Count();

            return count;
        }

        public int countJudges()// count amount of  judges
        {
            int count = 0;

            count = judgeList.Count();

            return count;
        }
    }
}
