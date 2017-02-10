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

        public double pointResult(double j1,double j2,double j3, double j4, double j5, double difficulty) //returning the result to the judge
        {
            double n = 0;
            List<double> pointList = new List<double>(); 
            pointList.Add(j1);
            pointList.Add(j2);
            pointList.Add(j3);
            pointList.Add(j4);
            pointList.Add(j5);

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
