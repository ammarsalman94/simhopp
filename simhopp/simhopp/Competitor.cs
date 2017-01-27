using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
namespace simhopp
{
    public class Competitor
    {
        //Declaring Variables
        private string name;
        private int    age;
        private string    id;
        private int    qtyOfJumps;
       // private float  score;
        private List<Competitor>jumpList;
        
        
        public void addCompetitor() // Creating new competitor
        {
            jumpList.Add(new Competitor() );
        } 

        public void testEmpty()
        {
      
        }

        public void countScore() //count score to competitor
        {  

        }

         
        public void sendInfoToJudge() //send info about competitor to judge
        {

        }

        public Competitor() //Constructor
        {
            this.name = "Default";
            this.age = 0;
            this.id = "0000";


            //List<Competitor> jumplist = new List<Competitor>();
        }

        
    }
}
