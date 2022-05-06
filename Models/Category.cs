using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace BabyStore.Models
{
    public class Category
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "El nombre de la categoria no puede estar vacia")]
        [StringLength(50, MinimumLength = 3,ErrorMessage ="Porfavor ingrese un nombre de 3 a 50 caracteres")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$",ErrorMessage ="Ingrese una categoria que empieze con mayusculas seguido de letras y espacios solamente")]
        [Display(Name ="Nombre Categoria")]
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}