using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u18242937_HW04.Models
{
    public abstract class Energy

    {
        public int RecycleID { get; set; }
        public string Sponsor { get; set; }
        public double JetFuel { get; set; }
        public int Gate { get; set; }
                    
   

        public Energy(int recycleID, string sponsor, double jetfuel, int gate)
        {
            RecycleID = recycleID;
            Sponsor = sponsor;
            JetFuel = jetfuel;
            Gate = gate;

        }
        public Energy() { }

        public abstract double CalculateCost();

        public virtual double AccumulatedCost()
        {
          return Gate * JetFuel;
        }




    }
}