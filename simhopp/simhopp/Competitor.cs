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
        private List<JumpType> competitor = new List<JumpType>();
        
        public void jump()
        {

        }

        public void authenticate()
        {

        }

        public void addCompetitor() // Creating new competitor
        {
            
        } 
        

        public void countScore() //count score to competitor
        {  

        }

         
        public void sendInfoToJudge() //send info about competitor to judge
        {

        }

        public Competitor(string name, int age, string id) //Constructor
        {
            this.name = name;
            this.age = age;
            this.id = id;
       
            //List<Competitor> jumplist = new List<Competitor>();
        }

        
    }
}
