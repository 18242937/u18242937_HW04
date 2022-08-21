using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u18242937_HW04.Models
{
    public static class List
    {
        public static readonly List<Energy> recycles = new List<Energy> ();

        public static void Add(Energy recycle)
        {
            recycles.Add(recycle);
        }

        public static List<Energy> Recycles()
        {
            return recycles;
        }

        public static void Delete(int id)
        {
           for(int i = 0; i < recycles.Count; i++)
            {
                if (recycles[i].RecycleID == id)
                {
                    recycles.Remove(recycles[i]);
                }
            }
          
        }

        public static void Edit(Energy recycle)
        {
            if(recycle.GetType () == typeof(Factory))
            {
                Factory factory = (Factory)recycle;
                for(int i = 0; i < recycles.Count; i++)
                {
                    if(recycles[i].RecycleID == factory.RecycleID)
                    {
                        recycles[i] = factory;
                    }
                }
               

            }

            if (recycle.GetType() == typeof(Airlines))
            {
                Airlines airlines = (Airlines)recycle;
                for (int i = 0; i < recycles.Count; i++)
                {
                    if (recycles[i].RecycleID == airlines.RecycleID)
                    {
                        recycles[i] = airlines;
                    }
                }


            }

        }
    }
}