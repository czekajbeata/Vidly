using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public byte Id { get; set; }

      //  [Required]
        public string Name { get; set; }

        //[Required]
        public Genre Genre { get; set; }

        public byte GenreId { get; set; }

      //  [Required]
        [Display (Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

     //   [Required]
        [Display(Name = "Number In Stock")]
        public byte NumberInStock { get; set; }

    }
}