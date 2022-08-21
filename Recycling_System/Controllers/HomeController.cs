using u18242937_HW04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace u18242937_HW04.Controllers
{
    public class HomeController : Controller
    {
        // Repository 
       
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Home()
        {
           
            return View(List.Recycles());
        }

        public ActionResult Factory()
        {
            
            return View();
        }
        public ActionResult Airlines()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Factory(string sponsor, int jetfuel, int gate, string factoryType, string jobs, int energyGrade)
        {
            Random random = new Random();
            int id = random.Next(1, 10000000);
            Factory factory = new Factory(id, sponsor, jetfuel, gate, factoryType, jobs, energyGrade);
            List.Add(factory);
            
            return View();
        }

        [HttpPost]
        public ActionResult Airlines(string sponsor, int jetfuel, int gate, double landingZone, string airLineType)
        {
            int id = 0;
            Airlines airlines = new Airlines(id, sponsor, jetfuel, gate, airLineType, landingZone);
            List.Add(airlines);
            id++;
            return View();
        }

        public ActionResult Delete(int id)
        {
            List.Delete(id);
           return RedirectToAction("Home");
        }

        public ActionResult EditNonEntry(int id)
        {

            Factory factory = (Factory)List.recycles.FirstOrDefault(x => x.RecycleID == id);
            return View(factory);
        }

        public ActionResult EditreEntry(int id)
        {

            Airlines airlines = (Airlines)List.recycles.FirstOrDefault(x => x.RecycleID == id);
            return View(airlines);
        }

        [HttpPost]
        public ActionResult EditreEntry(Airlines airlines)
        {
            List.Edit(airlines);

            return RedirectToAction("Home");
        }

        [HttpPost]
        public ActionResult EditNonEntry(Factory factory)
        {
            List.Edit(factory);

            return RedirectToAction("Home");
        }

        public ActionResult ViewEnergy()
        {
            ViewBag.Message = "Your contact page.";

            return RedirectToAction("Home");
        }
    }
}