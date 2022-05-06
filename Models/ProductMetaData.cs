using System;
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
        [Required(ErrorMessage = "El nombre del producto no puede estar en blanco")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Porfavor ingrese un nombre  de 3 a 50 caracteres")]
        [RegularExpression(@"^[a-zA-Z0-9'-'\s]*$", ErrorMessage = "Ingrese un nombre de solo letras y numeros y espacios")]
        public string Name { get; set; }

        [Required(ErrorMessage = "La descripcion del producto no puede estar en blanco")]
        [StringLength(200, MinimumLength = 10, ErrorMessage = "Ingrese una descripcion de 10 a 200 caracteres")]
        [RegularExpression(@"^[,;a-zA-Z0-9'-'\s]*$", ErrorMessage = "Ingrese un producto que contenga letras, numeros y espacios")]
        [DataType(DataType.MultilineText)]
         public string Description { get; set; }

        [Required(ErrorMessage = "El precio no puede estar vacio")]
        [Range(0.10, 10000, ErrorMessage = "Ingrese un precio entre 0.10 a 10000.00")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:c}")]


        [RegularExpression("[0-9]+(\\.[0-9][0-9]?)?", ErrorMessage = "El precio debe de ser un numero con hasta dos (.) decimales")]
        [Display(Name = "Precio")]
        public decimal Price { get; set; }
    }

}