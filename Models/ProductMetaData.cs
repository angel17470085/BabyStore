﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace BabyStore.Models
{
    [MetadataType(typeof(ProductMetaData))]
    public partial class Product
    {
    }

    public class ProductMetaData
    {
        [Display(Name="Producto")]
        public string Name { get; set; }

        [Display(Name="Descripcion")]
        public string Description { get; set; }

        [Display(Name = "Precio")]
        public decimal Price { get; set; }
    }

}