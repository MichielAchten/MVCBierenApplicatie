using MVCBierenApplicatie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBierenApplicatie.Services
{
    public class BierService
    {
        private static Dictionary<int, Bier> bieren = new Dictionary<int, Bier>();

        static BierService()
        {
            //bieren[1] = new Bier { ID = 15, Naam = "Felix", Alcohol = 0.07f };
            //bieren[2] = new Bier { ID = 17, Naam = "Roman", Alcohol = 0.075f };
            bieren[3] = new Bier { ID = 1, Naam = "Cnudde kriek", Alcohol = 4.7f };
            bieren[4] = new Bier { ID = 2, Naam = "Liefmans goudenband", Alcohol = 8f };
            bieren[5] = new Bier { ID = 3, Naam = "Sloeber", Alcohol = 7.5f };
            bieren[6] = new Bier { ID = 4, Naam = "Felix kriekbier", Alcohol = 5f };
        }

        public List<Bier> FindAll()
        {
            return bieren.Values.ToList();
        }
    }
}