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

        public void addCompetitorToList(Competitor obj)
        {
            competitorList.Add(obj);
        }

        public void addJudgeToList(Judge obj)
        {
            judgeList.Add(obj);
        }

        public int countJumps()
        {
            int count = 0;

            count = competitorList.Count();

            return count;
        }

        public int countJudges()
        {
            int count = 0;

            count = judgeList.Count();

            return count;
        }
    }
}
