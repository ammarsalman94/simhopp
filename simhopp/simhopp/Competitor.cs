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
        static int competitorId = 1;
        public string name { get; set; } = "";
        public int age { get; set; } = 0;
        public int id { get; set; } = 0;
        public int qtyOfJumps { get; set; } = 0;

        // private float  score;
        private SortedList<float, List<string>> competitorJumps = new SortedList<float, List<string>>();

        public Competitor(string name, int age) //Constructor
        {
            this.name = name;
            this.age = age;
            id = getcompetitorNextID();
            competitorJumps = null;

            //List<Competitor> jumplist = new List<Competitor>();
        }
        public void jump()
        {

        }

        /// <summary>
        /// why do we need this here? 
        /// It should be declared in the client, not in the competitorclass.
        /// </summary>
        public void authenticate()
        {

        }
        protected int getcompetitorNextID() // pointing to the next id, useful when adding more competitor-information.
        {
            return competitorId++;
        }

        public void addCompetitor() // Creating new competitor
        {

        }

        public int testCount()  // Counts how many objects a list has.
        {
            int c = 0;
            c = competitorJumps.Count();
            return c;

        }

        public void countScore() //count score to competitor
        {

        }


        public void sendInfoToJudge() //send info about competitor to judge
        {

        }


        public void addJumpTypeToCompetitor()
        {

            string holdJump;
            var obj1 = new JumpType();
           holdJump = obj1.createCompleteJump();
          Console.WriteLine($"holdJump:{holdJump}" );

            float holdPoints = 0;
            var obj2 = new Points();
            holdPoints = obj2.addPoints(9);



           

          //competitorJumps.Add(holdPoints, holdJump);

        }
        
    }
}
