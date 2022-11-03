
using System;using PetrolStation;

namespace PetrolStation
{
    class HVG : Vehicle
    {
        public HVG(List<string> fuelType, string vehicleType, int tankSize, int startingFuel, int newVehicleCreation,int vehicleTankSize = 150)
            : base(fuelType, vehicleType, tankSize, startingFuel, newVehicleCreation)
        {
            //int vehicleTankSize = 150;
            Random random = new Random();
            startingFuel = random.Next(0, 75);
            fuelType = new List<string>() { "Diesel"};
            vehicleType = "HVG";
        }
    }

}