using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Movies.Models
{
    public class Context : DbContext
    {
        public Context() : base("MoviesDB")
        {

        }
        public DbSet<Movie> MovieContext { get; set; }
        public DbSet<Director> DirectorContext { get; set; }
    }
}