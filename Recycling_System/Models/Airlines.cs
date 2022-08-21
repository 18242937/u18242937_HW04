using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u18242937_HW04.Models
{
    public class Airlines: Energy
    {
        public string AirlineType { get; set; }    
        public double LandingZones { get; set; }
 

        public Airlines(int recycleID, string sponsor, double jetfuel, int gate,string airLineType, double landingZone) : base(recycleID, sponsor, jetfuel, gate)
        {
            AirlineType = airLineType;
            LandingZones = landingZone;
           
        }

        public Airlines():base()
        {

        }

        public override double CalculateCost()
        {
            return LandingZones * 500;
         }

    }
}