﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCBierenApplicatie.Models
{
    public class Bier
    {
        public int ID { get; set; }
        public string Naam { get; set; }
        [UIHint("alcoholPercentageKleur")]
        public float Alcohol { get; set; }
    }
}