using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Movies.Models
{
    public class Movie
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        
        //[Required]
        [Display(Name = "Director")]
        public virtual Director DirectorName { get; set; }
        
        [Required]
        public virtual int DirectorId { get; set; }

        [Display(Name = "Release year")]
        public int ReleaseYear { get; set; }

        [Display(Name = "Duration in minutes")]
        public int Duration { get; set; }

        public string Budget { get; set; }

        public string Description { get; set; }

        public int CompareTo(Movie other)
        {
            return this.Id.CompareTo(other.Id);
        }
    }
}