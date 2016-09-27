using MVCBierenApplicatie.Models;
using MVCBierenApplicatie.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBierenApplicatie.Controllers
{
    public class BierController : Controller
    {
        // GET: Bier

        private BierService bierservice = new BierService();
        
        public ActionResult Index()
        {
            var bieren = bierservice.FindAll();
            return View(bieren);

            //List<Bier> bieren = new List<Bier>();
            //bieren.Add(new Bier { ID = 15, Naam = "Felix", Alcohol = 0.07f });
            //bieren.Add(new Bier { ID = 17, Naam = "Roman", Alcohol = 0.075f });
            //return View(bieren);
        }
    }
}