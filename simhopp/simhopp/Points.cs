using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simhopp
{
    public class Points //class dealing with points in the competition
    {
        public double points{ get; set; } = 0; //getters n setters, plus default


        public void getInfoJump() //getting information about the jump, height, type etc.
        {
            
        }

        public void pointConstraints() //Different constraints revolving the point-distribution.
        {
            
        }


        public double pointResult(params double[] judgeScore, double difficulty) //returning the result to the judge
        {
            double n = 0;
            List<double> pointList = new List<double>(); 
            pointList.Add(judgeScore[0]);
            pointList.Add(judgeScore[1]);
            pointList.Add(judgeScore[2]);
            pointList.Add(judgeScore[3]);
            pointList.Add(judgeScore[4]);

            pointList.Remove(pointList.Max());
            pointList.Remove(pointList.Min());

           n =  pointList.Sum() * difficulty;


            return n;


        } 

        public double SendPointToCompetitor(double point)
        {


            this.points = points;
            return point;
        }
    }
}
