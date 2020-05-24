﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Veterinaria.Web.Models
{
    public class Pet
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Nombre")]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Tipo")]
        [MaxLength(50)]
        public string PetType { get; set; }
        [Display(Name = "Edad")]

        public int Age { get; set; }
        [Display(Name = "Nacimiento")]
        public DateTime BirthDate { get; set; }
        [Required]
        [MaxLength(50)]
        public string Color { get; set; }
        [MaxLength(50)]
        public string Raza { get; set; }
        [Required]
        [Display(Name = "Peso")]
        public decimal Weight { get; set; }
        [Required]
        [Display(Name = "Altura")]
        public decimal Height { get; set; }
        public string imgUrl { get; set; }
        public Owner Owner { get; set; }
        public ICollection<Consult> Consults { get; set; }
    }
}