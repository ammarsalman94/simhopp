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
        private string name { get; set; } = ""; //default values and getters n setters.
        private int    age { get; set; } = 0;
        private int    id { get; set; } = 0;
        private int    qtyOfJumps { get; set; } = 0;
        private float  score { get; set; } = 0;
        private List<JumpType>jumpList;
        
        
        public void newCompetitor() // Creating new competitor
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
            
        }

        
    }
}
