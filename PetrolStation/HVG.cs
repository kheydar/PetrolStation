using System;
using PetrolStation;

namespace PetrolStation
{
    class HVG : Vehicle
    {
        public HVG( int startingFuel, int newVehicleCreation = 1500, int vehicleTankSize = 150, string vehicleFuelType = "Diesel", string typeofVehicle = "HVG")
            : base(vehicleFuelType, typeofVehicle, vehicleTankSize, startingFuel, newVehicleCreation)
        {
            Random random = new Random();
            startingFuel = random.Next(0, 75);

        }
    }

}