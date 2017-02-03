using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simhopp
{
    public class Judge : Points
    {
        static int judgeId = 1;
        private string name;
        private int age;
        private int id;

        public float  score; //Flytta

        public Judge(string name, int age)
        {
            this.name = name;
            this.age = age;
            id = getcompetitorNextID();
        }
        public int getcompetitorNextID() // pointing to the next id, useful when adding more competitor-information.
        {
            return judgeId++;
        }

    
        public void addJudge()
        {
            
           // name = Convert.ToString(Console.ReadLine());
           // age = Convert.ToInt32(Console.ReadLine());
            //generateId();
            //Judge(name, age, /*generateId()*/);
        }

        public void authenticate()
        {

        }

        public void sendScoreToCompetitor()
        {

        }

        public double setPoint()
        {

            return 0;
        }
        public Judge()
        {

        }

    
    }
}