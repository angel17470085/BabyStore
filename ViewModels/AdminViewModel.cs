using BabyStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace BabyStore.ViewModels
{
    public class RoleViewModel
    {

        public string Id  { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Nombre del Rol")]
        public string Name { get; set; }

    }
    public class EditUserViewModel
    {
        public string Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Nombre(s)")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Apellido(s)")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Nacimiento")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }

        public Address Address { get; set; }
        public IEnumerable<SelectListItem> RolesList { get; set; }

    }
}