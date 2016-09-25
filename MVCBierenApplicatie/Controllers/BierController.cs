using MVCBierenApplicatie.Models;
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
        public ActionResult Index()
        {
            List<Bier> bieren = new List<Bier>();
            bieren.Add(new Bier { ID = 1, Naam = "Crystal", Alcohol = 0.1f });
            bieren.Add(new Bier { ID = 2, Naam = "Jupiler", Alcohol = 0.05f });
            bieren.Add(new Bier { ID = 3, Naam = "Leffe", Alcohol = 0.07f });
            return View(bieren);
        }
    }
}