using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6._1._2
{
    internal class House
    {
        public string? HouseNumber { get; set; }
        public string? StreetAddress { get; set; }
        public string? HouseType { get; set; }

        public House(string houseNum, string street, string type)
        {
            HouseNumber = houseNum;
            StreetAddress = street;
            HouseType = type;
        }

        override public string ToString()
        {
            string houseData = $"{HouseNumber}, {StreetAddress}\nType: {HouseType}";
            return houseData;
        }
    }
}
