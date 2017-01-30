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
        private string name;
       // private List<Competition> competition = new List<Competition>();
        private List<Judge> Judge = new List<Judge>();
        private List<Competitor> competitor = new List<Competitor>(); 



        //Functions

        public Competition() //Creating competition
        {

        }

        private int countCompetitors()
        {
            int count = 0;

            for (int i = 0; i < competitor.Count(); i++)
            {
                count++;
            }
            return count;
        }



    }
}
