using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Assignment_11._3
{
    internal class Genre
    {
        [Key]
        public Guid GenreId { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
    }
}
