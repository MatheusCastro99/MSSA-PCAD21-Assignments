using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Assignment_11._3
{
    internal class Movie
    {
        [Key]
        public Guid MovieId { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Genre { get; set; }
        public int ReleaseYear { get; set; }
    }
}
