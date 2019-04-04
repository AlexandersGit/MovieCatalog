using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movies.Models
{
    public class MovieAddView
    {
        public Movie Movie { get; set; }
        public List<Director> Directors { get; set; }
    }
}