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
            //bieren[15] = new Bier { ID = 15, Naam = "Felix", Alcohol = 0.07f };
            //bieren[17] = new Bier { ID = 17, Naam = "Roman", Alcohol = 0.075f };
            bieren[1] = new Bier { ID = 1, Naam = "Cnudde kriek", Alcohol = 4.7f };
            bieren[2] = new Bier { ID = 2, Naam = "Liefmans goudenband", Alcohol = 8f };
            bieren[3] = new Bier { ID = 3, Naam = "Sloeber", Alcohol = 7.5f };
            bieren[4] = new Bier { ID = 4, Naam = "Felix kriekbier", Alcohol = 5f };
            bieren[5] = new Bier { ID = 5, Naam = "Romy pils", Alcohol = 4.5f };
            bieren[6] = new Bier { ID = 6, Naam = "Leffe blond", Alcohol = 2.5f };
            bieren[7] = new Bier { ID = 7, Naam = "Rodenbach", Alcohol = 3.5f };
            bieren[8] = new Bier { ID = 8, Naam = "Liefmans goudband", Alcohol = 6f };
            bieren[9] = new Bier { ID = 9, Naam = "Duvel", Alcohol = 7f };

        }

        //private static Dictionary<int, Bier> bieren = new Dictionary<int, Bier>
        //{
        //    {1,new Bier { ID = 1, Naam = "Cnudde kriek", Alcohol = 4.7f }},
        //    {2,new Bier { ID = 2, Naam = "Liefmans goudenband", Alcohol = 8f }},
        //    {3,new Bier { ID = 3, Naam = "Sloeber", Alcohol = 7.5f }},
        //    {4,new Bier { ID = 4, Naam = "Felix kriekbier", Alcohol = 5f }}
        //};

        public List<Bier> FindAll()
        {
            return bieren.Values.ToList();
        }

        public Bier Read(int id)
        {
            return bieren[id];
        }

        public void Delete(int id)
        {
            bieren.Remove(id);
        }

        public void Add(Bier bier)
        {
            bier.ID = bieren.Keys.Max() + 1;
            bieren.Add(bier.ID, bier);
        }
    }
}