using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Assignments_10._3
{
    internal class Car
    {
        [Key]
        public string VIN {  get; set; }
        public string Maker {  get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public bool IsAvailable { get; set; }
    }
}
