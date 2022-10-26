
using System;using PetrolStation;

namespace PetrolStation
{
    class HVG : Vehicle
    {
        public HVG(string fuel, string type, int size, int startingFuel, int newVehicleCreation,int vehicleTankSize = 150)
            : base(fuel, type, size, startingFuel, newVehicleCreation)
        {
            //int vehicleTankSize = 150;
            //fuel = "Diesel";
        }
    }

}