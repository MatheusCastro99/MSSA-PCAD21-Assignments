using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_7._4
{
    internal class ParkingSystem
    {
        public int BigParkingSpaces { get; set; }
        public int MediumParkingSpaces { get; set; }
        public int SmallParkingSpaces { get; set; }

        public ParkingSystem(int big, int medium, int small)
        {
            BigParkingSpaces = big;
            MediumParkingSpaces = medium;
            SmallParkingSpaces = small;
        }

        public bool AddCar(int carType)
        {
            switch (carType)
            {

                case 1:
                    if (BigParkingSpaces > 0)
                    {
                        BigParkingSpaces--;
                        return true;
                    }
                    break;
                case 2:
                    if (MediumParkingSpaces > 0)
                    {
                        MediumParkingSpaces--;
                        return true;
                    }
                    break;
                case 3:
                    if (SmallParkingSpaces > 0)
                    {
                        SmallParkingSpaces--;
                        return true;
                    }
                    break;
            }

            return false;
        }

        public override string ToString()
        {
            return $"Spots available:\nBig: {BigParkingSpaces}, Medium: {MediumParkingSpaces}, Small: {SmallParkingSpaces}";
        }
    }
}
