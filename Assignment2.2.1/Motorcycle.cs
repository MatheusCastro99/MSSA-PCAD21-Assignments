using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2._2
{
    public class Motorcycle: Vehicle
    {
        public string Style { get; set; }
        public string noiseLevel { get; set; }
        
        public Motorcycle(string make, string style, string noiseLevel)
        {
            Make = make;
            Style = style;
            this.noiseLevel = noiseLevel;
        }

        public override string ToString()
        {
            return $"{Make} {Style} ({noiseLevel})";
        }

        public override void Beep()
        {
            Console.WriteLine("Motorcycle is beeping.");
        }
    }
}
