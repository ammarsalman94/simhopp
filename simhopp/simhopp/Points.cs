using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simhopp
{
    public class Points //class dealing with points in the competition
    {
        private float points{ get; set; } = 0; //getters n setters, plus default


        public void getInfoJump() //getting information about the jump, height, type etc.
        {
            
        }

        public void pointConstraints() //Different constraints revolving the point-distribution.
        {
            
        }


        public double pointResult(double j1,double j2,double j3, double j4, double j5) //returning the result to the judge
        {
            double n = 0;
            double difficulty = 10;
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

        public void getPoints()
        {

        }
    }
}
