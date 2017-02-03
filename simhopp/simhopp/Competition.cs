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
        static int competitionId=1;
        private int id;
        public string name;
        private List<Competitor> competitorList = new List<Competitor>();
        private List<Judge> judgeList = new List<Judge>();
       




        //Functions

        public Competition(string name) //Creating competition
        {
            id = getCompetitionNextID();
            this.name = name;

        }

        public int getCompetitionNextID() // pointing to the next id, useful when adding more competitor-information.
        {
            return competitionId++;
        }

        public void removeCompetitorFromList(int unId)
        {

            for (int i = competitorList.Count - 1; i >= 0; i--)
            {
                if (competitorList[i].id == unId)
                {
                    competitorList.RemoveAt(i);
                }
            }
        }

        public void removeJudgeFromList(int unId)
        {

            for (int i = judgeList.Count - 1; i >= 0; i--)
            {
                if (judgeList[i].id == unId)
                {
                    judgeList.RemoveAt(i);
                }
            }
        }

        public void printCompetitorList()
        {
            Console.WriteLine("Competitorlist");

            foreach (var obj in competitorList)
            {
                Console.WriteLine($"test: { obj.name.ToString()} , { obj.age.ToString()}, { obj.id.ToString()}");
            }
        }

        public void printJudgeList()
        {
            Console.WriteLine("Judgelist");

            foreach (var obj in judgeList)
            {
                Console.WriteLine($"test: { obj.name.ToString()} , { obj.age.ToString()}, { obj.id.ToString()}");
            }
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
