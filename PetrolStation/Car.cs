using System;
using System.Collections.Generic;
using PetrolStation;

namespace PetrolStation
{
    class Car : Vehicle  
    {
        public Car(List<string> fuelType, string vehicleType, int tankSize, int startingFuel, int newVehicleCreation, int vehicleTankSize = 50)
            : base(fuelType, vehicleType, tankSize, startingFuel, newVehicleCreation)
        {
            //int vehicleTankSize = 50;
            Random random = new Random();
            startingFuel = random.Next(0, 25);
            fuelType = new List<string>() { "Diesel", "Petrol", "LPG" };
            vehicleType = "Car";
        }
    }
}