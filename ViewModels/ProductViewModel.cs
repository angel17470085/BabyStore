using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace BabyStore.ViewModels
{
    public class ProductViewModel
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Nombre del producto no puede estar en blanco")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Ingresar un producto con minimo 3 caracteres, maximo 50")]
        [RegularExpression(@"^[a-zA-Z0-9'-'\s]*$", ErrorMessage = "Producto con letras y numeros solamente")]
        public string Name { get; set; }

        [Required(ErrorMessage = "La descripcion del producto no puede estar en blanco")]
        [StringLength(200, MinimumLength = 10, ErrorMessage = "Ingrese una descripcion del prouducto, minimo 10 caracteres y maximo 200")]
        [RegularExpression(@"^[,;a-zA-Z0-9'-'\s]*$", ErrorMessage = "Ingrese una descripcion del producto de solo letras y numeros")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required(ErrorMessage = "El precion no puede estar en blanco")]
        [Range(0.10, 10000, ErrorMessage = "Ingrese un precion entre 0.10 y 10000.00")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:c}")]
        [RegularExpression("[0-9]+(\\.[0-9][0-9]?)?", ErrorMessage = "El precio debe de ser un numero con 2 puntos decimales")]
        public decimal Price { get; set; }

        [Display(Name = "Categoria")]
        public int CategoryID { get; set; }

        public SelectList CategoryList { get; set; }

        public List<SelectList> ImageLists { get; set; }

        public string[] ProductImages { get; set; }
    }

    
}