using System;
using System.Collections.Generic;
using System.Text;

namespace MainView
{
    internal class Coffee : Beverage
    {
        public bool IsHot { get; set; }
        public int ShotCount { get; set; }
        public string Type { get; set; } = "";

        public Coffee(bool isHot, int shotCount, string coffeeType, string parentSize, bool parentIsCarbonated, double parentPrice ) : base(parentSize, parentIsCarbonated, parentPrice)
        {
            IsHot = isHot;
            ShotCount = shotCount;
            Type = coffeeType;
        }

        public Coffee() 
        {

        }
    }
}
