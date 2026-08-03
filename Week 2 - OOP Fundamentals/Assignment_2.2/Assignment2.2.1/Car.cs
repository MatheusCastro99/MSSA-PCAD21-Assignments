using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2._2
{
    public class Car: Vehicle
    {
        public string Model { get; set; }
        public string BaggageCapacity { get; set; }

        private bool locked;

        public Car(string make, string model, string baggageCapacity)
        {
            Make = make;
            Model = model;
            BaggageCapacity = baggageCapacity;
        }

        public override string ToString()
        {
            return $"{Make} {Model} ({BaggageCapacity})";
        }

        public void SwitchLock()
        {
            locked = !locked;
            if (locked) {
                Console.WriteLine("Car is locked.");
            }
            else {
                Console.WriteLine("Car is unlocked.");
            }
        }
    }
}
