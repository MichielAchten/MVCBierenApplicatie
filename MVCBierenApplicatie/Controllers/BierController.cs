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

        private BierService bierService = new BierService();
        
        public ActionResult Index()
        {
            var bieren = bierService.FindAll();
            return View(bieren);

            //List<Bier> bieren = new List<Bier>();
            //bieren.Add(new Bier { ID = 15, Naam = "Felix", Alcohol = 0.07f });
            //bieren.Add(new Bier { ID = 17, Naam = "Roman", Alcohol = 0.075f });
            //return View(bieren);
        }

        public ActionResult Verwijderen(int id)
        {
            var bier = bierService.Read(id);
            return View(bier);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var bier = bierService.Read(id);
            this.TempData["bier"] = bier;
            bierService.Delete(id);
            return Redirect("~/Bier/Verwijderd");
        }

        public ActionResult Verwijderd()
        {
            var bier = (Bier)this.TempData["bier"];
            return View(bier);
        }

        [HttpGet]
        public ActionResult Toevoegen()
        {
            var bier = new Bier();
            return View(bier);
        }

        [HttpPost]
        public ActionResult Toevoegen(Bier bier)
        {
            if (this.ModelState.IsValid)
            {
                bierService.Add(bier);
                return RedirectToAction("Index");
            }
            else
            {
                return View(bier);
            }
        }
    }
}