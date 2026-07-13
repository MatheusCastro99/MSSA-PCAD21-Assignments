using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2._2
{
    internal class Airplane: Vehicle
    {
        public int seatingCapacity { get; set; }
        public int wingspan { get; set; }
        public string location { get; set; }

        public Airplane(string make, int seatingCapacity, int wingspan, string location)
        {
            Make = make;
            this.seatingCapacity = seatingCapacity;
            this.wingspan = wingspan;
            this.location = location;
        }

        public override string ToString()
        {
            return $"{Make} ({seatingCapacity} seats, {wingspan}m wingspan) - Location: {location}";
        }

        public void TurnWings()
        {
            Console.WriteLine("Airplane is turning wings.");
        }

        public void LiftWheels()
        {
            Console.WriteLine("Airplane is lifting wheels.");
        }

        public void EjectLoudPassengers()
        {
            Console.WriteLine("Airplane is ejecting loud passengers.");
        }
    }
}
