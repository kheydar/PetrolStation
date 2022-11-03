using System;
using PetrolStation;

namespace PetrolStation
{
    class Van : Vehicle
    {
        public Van(List<string> fuelType, string vehicleType, int tankSize, int startingFuel, int newVehicleCreation, int vehicleTankSize = 80)
            : base(fuelType, vehicleType, tankSize, startingFuel, newVehicleCreation)
        {
            //int vehicleTankSize = 80;
            Random random = new Random();
            startingFuel = random.Next(0, 40);
            fuelType = new List<string>() { "Diesel", "LPG" };
            vehicleType = "Van";
        }
    }

}