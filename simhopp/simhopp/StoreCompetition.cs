using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simhopp
{
    public class StoreCompetition
    {

        public List<Competition> oldCompetitionList = new List<Competition>();

        public void addCompetition(Competition obj)
        {
            oldCompetitionList.Add(obj);
        }

        public void printOldCompetitionList()
        {


            foreach (var obj in oldCompetitionList)
            {
                Console.WriteLine($"Oldcompetition: { obj.name.ToString()} , { obj.id.ToString()}");
            }
        }

        private void addCompetionFromFile()
        {

        }

        private void loadCompetition()
        {

        }


        public void removeCompetittionFromList(int unId)
        {

            for (int i = oldCompetitionList.Count - 1; i >= 0; i--)
            {
                if (oldCompetitionList[i].id == unId)
                {
                    oldCompetitionList.RemoveAt(i);
                }
            }
        }

        public int countOldCompetitions()//counts amount of jumps
        {
            int count = 0;

            count = oldCompetitionList.Count();

            return count;
        }

        //public void printInfoAboutOldCompetition(string nameCompetition)
        //{

        //    Console.WriteLine("Information about old competition: ");
        //    var competition = new Competition(nameCompetition);

        //    foreach (var obj in oldCompetitionList)
        //    {

        //        if (obj.name == nameCompetition)
        //        {
        //            competition.printFullCompetition();
        //        } 
        //    }
        //}


    }
}
