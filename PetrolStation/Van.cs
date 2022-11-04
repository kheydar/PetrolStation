using System;
using PetrolStation;

namespace PetrolStation
{
    class Van : Vehicle
    {
        public Van(string vehicleFuelType, int startingFuel, int newVehicleCreation = 1500, int vehicleTankSize = 80, string typeofVehicle = "Van")
            : base(vehicleFuelType, typeofVehicle, vehicleTankSize, startingFuel, newVehicleCreation)

        {
            Random random = new Random();
            startingFuel = random.Next(0, 40);
            //vehicleFuelType = new string[] { "Diesel", "LPG" };
        }
    }

}