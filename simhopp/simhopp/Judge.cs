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
        public string name;
        public int age;
        public int id;

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

        //public int countJudges(Competition game)
        //{

        //    int amountJudges;

        //    amountJudges = game.countJudges();

        //    return amountJudges;
        //}

        public  void UseParams(params int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
        }

        public double sendScoreToCompetitor(Competition game, Competitor player)          //In progress
        {
            //var points = new Points();
            //points.SendPointToCompetitor(point);
            double Fail = 0;
            int amountJudges;
            amountJudges = game.countJudges();

            double Judge1;
            double Judge2;
            double Judge3;
            double Judge4;
            double Judge5;
            double Judge6;
            double Judge7;
            double Judge8;
            double Judge9;
            double Judge10;

            switch (amountJudges)
            {
            case 1:
                case 2:
                    return Fail;
            case 3:

                    //sin poäng
                    //Judge1 = 2;
                    //Judge2 = 3.6;
                    //Judge3 = 5;
                    return score;

                    
            case 4:
                    Judge1 = 2;
                    Judge2 = 3.6;
                    Judge3 = 5;
                    Judge4 = 2;
                    return score;
            case 5:
                    Judge1 = 2;
                    Judge2 = 3.6;
                    Judge3 = 5;
                    Judge4 = 2;
                    Judge5 = 1;
                    return score;
            case 6:
                    Judge1 = 2;
                    Judge2 = 3.6;
                    Judge3 = 5;
                    Judge4 = 2;
                    Judge5 = 1;
                    Judge6 = 0;
                    return score;
            case 7:
                    Judge1 = 2;
                    Judge2 = 3.6;
                    Judge3 = 5;
                    Judge4 = 2;
                    Judge5 = 1;
                    Judge6 = 0;
                    Judge7 = 7.3;
                    return score;
            case 8:
                    Judge1 = 2;
                    Judge2 = 3.6;
                    Judge3 = 5;
                    Judge4 = 2;
                    Judge5 = 1;
                    Judge6 = 0;
                    Judge7 = 7.3;
                    Judge8 = 4.5;
                    return score;
            case 9:
                    Judge1 = 2;
                    Judge2 = 3.6;
                    Judge3 = 5;
                    Judge4 = 2;
                    Judge5 = 1;
                    Judge6 = 0;
                    Judge7 = 7.3;
                    Judge8 = 4.5;
                    Judge9 = 2.5;
                    return score;
            case 10:
                    Judge1 = 2;
                    Judge2 = 3.6;
                    Judge3 = 5;
                    Judge4 = 2;
                    Judge5 = 1;
                    Judge6 = 0;
                    Judge7 = 7.3;
                    Judge8 = 4.5;
                    Judge9 = 2.5;
                    Judge10 = 3.4;
                    return score;
            }
            return Fail;
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