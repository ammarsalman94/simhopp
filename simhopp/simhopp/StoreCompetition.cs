﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simhopp
{
    class StoreCompetition
    {
        private List<Competition> competitionList = new List<Competition>();

        public void addCompetition(Competition obj)
        {
            competitionList.Add(obj);
        }

        public void printCompetitionList()
        {
            Console.WriteLine("Oldcompetitorlist");

            foreach (var obj in competitionList)
            {
                Console.WriteLine($"test: { obj.name.ToString()} , { obj.id.ToString()}");
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

            for (int i = competitionList.Count - 1; i >= 0; i--)
            {
                if (competitionList[i].id == unId)
                {
                    competitionList.RemoveAt(i);
                }
            }
        }
    }
}
