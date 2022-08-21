using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u18242937_HW04.Models
{
    public class Factory : Energy
    {
        public string FactoryType { get; set; }
        public string Jobs { get; set; }
        public int EnergyGrade{ get; set; }
        public Factory(int recycleID, string sponsor, double jetfuel, int gate, string factoryType, string jobs, int energyGrade) :base(recycleID, sponsor, jetfuel, gate)
        {
            FactoryType = factoryType;
            Jobs = jobs;
            EnergyGrade = energyGrade;
        }

        public Factory()
        {

        }
        public override double CalculateCost()
        {
            return 25;
        }
    }
}