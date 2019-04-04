using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Movies.Models
{
    public class Director
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Director name")]
        public string Name { get; set; }

        [Display(Name = "Year of birth")]
        public int BirthYear { get; set; }

        public string Nationality { get; set; }
    }
}