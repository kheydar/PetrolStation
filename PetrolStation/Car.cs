using System;
using PetrolStation;

Random random = new Random();


namespace PetrolStation
{
    class Car : Vehicle  
    {
        private readonly Random random = new Random();
        //private string randfuel;

        public Car(string vehicleFuelType, int startingFuel, int newVehicleCreation = 1500, int vehicleTankSize = 50, string typeofVehicle = "Car")
            : base(vehicleFuelType, typeofVehicle, vehicleTankSize, startingFuel, newVehicleCreation)

        {
            startingFuel = random.Next(0, 25);
            //FuelType = new string[] { "Diesel", "Petrol", "LPG" };
        }

      
    }

}