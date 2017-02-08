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
        static int jumpId = 1;
        public string name { get; set; } = "";
        public int age { get; set; } = 0;
        public int id { get; set; } = 0;
        public int qtyOfJumps { get; set; } = 0;

        // private float jumptype and score;
        public Dictionary<int, Dictionary<string, double>> competitorJumps = new Dictionary<int, Dictionary<string, double>>();

        public Competitor(string name, int age) //Constructor
        {
            this.name = name;
            this.age = age;
            id = getcompetitorNextID();
            // competitorJumps = null;

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
        protected int getJumpNextID() // pointing to the next id, useful when adding more competitor-information.
        {
            return jumpId++;
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


        public void addJumpTypeToCompetitor(double point, int var1, int var2, string jumpstyle, int var3, int var4, double var5, int var6, int var7)
        {
            var obj1 = new JumpType();
            var holdJump = obj1.createCompleteJump(var1, var2, jumpstyle, var3, var4, var5, var6, var7);
            var points = new Points();
            var holdPoint = points.SendPointToCompetitor(2);
           

            competitorJumps.Add(getJumpNextID(), new Dictionary<string, double>() { { holdJump, holdPoint} });
                
               
        }


        //public Dictionary<int, Dictionary<string, double>> addToCompetitorJumps(int hej1,string hej2,double hej3) 
        //{
        //    competitorJumps.Add(hej1 , new Dictionary<string, double>(hej2, hej3) { });
        //    return competitorJumps;    
        //}

        public void printCompetitorJumps()
        {
            foreach (var pair in competitorJumps)
            {
               // Console.WriteLine($"jumpid: {obj.Keys}");

                foreach (var innerpair in pair.Value)
                {
                    
              //      Console.WriteLine($"jumptype and point: {obj2}");

                }
                
            }

        }

        public int countCompetitorJumps()//counts amount of jumps
        {
            int count = 0;
            count = competitorJumps.Count();
            return count;
        }

        //public void searchCompetitorjumps(int id)
        //{
        //    if (competitorJumps.ContainsKey(id))
        //    {
        //        Console.WriteLine($"{id}");
        //        competitorJumps.ContainsValue();

        //    }
        //}

        public void searchCompetitorjumps(int id)
        {
            
            if (competitorJumps.ContainsKey(id))
            {
                competitorJumps.ElementAt(id);
                Console.WriteLine($"{competitorJumps.ElementAt(id-1)}");
            }

            else
            {
                Console.WriteLine("Id does not exist");
            }
        }
    }
}
