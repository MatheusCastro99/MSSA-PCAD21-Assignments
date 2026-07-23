using System;
using System.Collections.Generic;
using System.Text;

namespace MainView
{
    internal abstract class Beverage
    {
        public string SizeOZ { get; set; } = "";
        public bool IsCarbonated { get; set; }
        public double Price { get; set; }

        public Beverage(string size, bool isCarbonated, double price) 
        {
            SizeOZ = size;
            IsCarbonated = isCarbonated;
            Price = price;
        }

        public Beverage() { }

    }
}
