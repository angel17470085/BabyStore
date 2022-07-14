using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BabyStore.Models
{
    public class Address
    {
        [Required]
        [Display(Name = "Direccion 1 ")]
        public string AddressLine1 { get; set; }
        [Display(Name = "Direccion 2")]
        public string AddressLine2 { get; set; }

        [Required]
        [Display(Name ="Colonia")]
        public string Town { get; set; }

        [Required]
        [Display(Name ="Municipio")]
        public string County { get; set; }

        [Display(Name ="Codigo Postal")]
        [Required]
        public string Postcode { get; set; }
    }
}