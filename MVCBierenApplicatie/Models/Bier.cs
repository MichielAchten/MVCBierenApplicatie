using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCBierenApplicatie.Models
{
    public class Bier
    {
        [DisplayFormat(DataFormatString = "{0:000}")]
        public int ID { get; set; }
        [Required]
        [StringLength(20,ErrorMessage="Max. {1} tekens voor {0}")]
        public string Naam { get; set; }
        [UIHint("alcoholPercentageKleur")]
        [ValidationAttributes.Alcoholpercentage(ErrorMessage="{0} heeft een ongeldige waarde")]
        public float Alcohol { get; set; }
    }
}